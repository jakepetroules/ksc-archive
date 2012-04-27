#include <fstream>
#include <iostream>
#include <string>
#include <vector>
#include <cstring>
#include <memory>
#include <sstream>

#include <botan/botan.h>

using namespace Botan;

SecureVector<byte> b64_decode(const std::string&);

std::string decrypt(std::string ciphertext, std::string passphrase)
{
    Botan::LibraryInitializer init;
    std::string algo = "DES";

    try
    {
        std::stringstream in(ciphertext.c_str());
        std::string header, salt_str, mac_str;
        std::getline(in, header);
        std::getline(in, algo);
        std::getline(in, salt_str);
        std::getline(in, mac_str);

        if (header != "-------- ENCRYPTED FILE --------")
        {
            std::cout << "ERROR: File is missing the usual header" << std::endl;
            return "";
        }

        const BlockCipher* cipher_proto = global_state().algorithm_factory().prototype_block_cipher(algo);

        if (!cipher_proto)
        {
            std::cout << "Don't know about the block cipher \"" << algo << "\"\n";
            return "";
        }

        const u32bit key_len = cipher_proto->maximum_keylength();
        const u32bit iv_len = cipher_proto->block_size();

        std::auto_ptr<PBKDF> pbkdf(get_pbkdf("PBKDF2(SHA-1)"));

        const u32bit PBKDF2_ITERATIONS = 8192;

        SecureVector<byte> salt = b64_decode(salt_str);
        SymmetricKey bc_key = pbkdf->derive_key(key_len, "BLK" + passphrase, &salt[0], salt.size(), PBKDF2_ITERATIONS);
        InitializationVector iv = pbkdf->derive_key(iv_len, "IVL" + passphrase, &salt[0], salt.size(), PBKDF2_ITERATIONS);
        SymmetricKey mac_key = pbkdf->derive_key(16, "MAC" + passphrase, &salt[0], salt.size(), PBKDF2_ITERATIONS);

        Pipe pipe(new Base64_Decoder, get_cipher(algo + "/CBC", bc_key, iv, DECRYPTION),
            new Fork(0, new Chain(new MAC_Filter("HMAC(SHA-1)", mac_key), new Base64_Encoder)));
        pipe.start_msg();
        in >> pipe;
        pipe.end_msg();

        std::string our_mac = pipe.read_all_as_string(1);
        if (our_mac != mac_str)
            std::cout << "WARNING: MAC in message failed to verify\n";

        return pipe.read_all_as_string(0);
    }
    catch (Algorithm_Not_Found)
    {
        std::cout << "Don't know about the block cipher \"" << algo << "\"\n";
        return "";
    }
    catch (Decoding_Error)
    {
        std::cout << "Bad passphrase or corrupt file\n";
        return "";
    }
    catch (std::exception& e)
    {
        std::cout << "Exception caught: " << e.what() << std::endl;
        return "";
    }
}

SecureVector<byte> b64_decode(const std::string& in)
{
    Pipe pipe(new Base64_Decoder);
    pipe.process_msg(in);
    return pipe.read_all();
}
