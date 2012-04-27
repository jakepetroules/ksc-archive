#include <fstream>
#include <iostream>
#include <string>
#include <vector>
#include <cstring>
#include <memory>
#include <sstream>

#include <botan/botan.h>

using namespace Botan;

std::string b64_encode(const SecureVector<byte>&);

std::string encrypt(std::string plaintext, std::string passphrase)
{
    Botan::LibraryInitializer init;

    std::string algo = "DES";

    try
    {
        const BlockCipher* cipher_proto = global_state().algorithm_factory().prototype_block_cipher(algo);

        if (!cipher_proto)
        {
            std::cout << "Don't know about the block cipher \"" << algo << "\"\n";
            return "";
        }

        const u32bit key_len = cipher_proto->maximum_keylength();
        const u32bit iv_len = cipher_proto->block_size();

        AutoSeeded_RNG rng;

        std::auto_ptr<PBKDF> pbkdf(get_pbkdf("PBKDF2(SHA-1)"));

        SecureVector<byte> salt(8);
        rng.randomize(&salt[0], salt.size());

        const u32bit PBKDF2_ITERATIONS = 8192;

        SymmetricKey bc_key = pbkdf->derive_key(key_len, "BLK" + passphrase, &salt[0], salt.size(), PBKDF2_ITERATIONS);
        InitializationVector iv = pbkdf->derive_key(iv_len, "IVL" + passphrase, &salt[0], salt.size(), PBKDF2_ITERATIONS);
        SymmetricKey mac_key = pbkdf->derive_key(16, "MAC" + passphrase, &salt[0], salt.size(), PBKDF2_ITERATIONS);

        // Just to be all fancy we even write a (simple) header.
        std::stringstream out;
        out << "-------- ENCRYPTED FILE --------" << std::endl;
        out << algo << std::endl;
        out << b64_encode(salt) << std::endl;

        Pipe pipe(new Fork(new Chain(new MAC_Filter("HMAC(SHA-1)", mac_key), new Base64_Encoder),
            new Chain(get_cipher(algo + "/CBC", bc_key, iv, ENCRYPTION), new Base64_Encoder(true))));

        pipe.start_msg();
        std::stringstream plaintextstream;
        plaintextstream << plaintext;
        plaintextstream >> pipe;
        pipe.end_msg();

        out << pipe.read_all_as_string(0) << std::endl;
        out << pipe.read_all_as_string(1);
        return out.str();
    }
    catch (Algorithm_Not_Found)
    {
        std::cout << "Don't know about the block cipher \"" << algo << "\"\n";
        return "";
    }
    catch (std::exception& e)
    {
        std::cout << "Exception caught: " << e.what() << std::endl;
        return "";
    }
}

std::string b64_encode(const SecureVector<byte>& in)
{
    Pipe pipe(new Base64_Encoder);
    pipe.process_msg(in);
    return pipe.read_all_as_string();
}
