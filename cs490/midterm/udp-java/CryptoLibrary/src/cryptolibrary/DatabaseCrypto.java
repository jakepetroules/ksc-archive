package cryptolibrary;

import java.io.ByteArrayInputStream;
import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.io.StringReader;
import java.io.UnsupportedEncodingException;
import java.nio.ByteBuffer;
import java.nio.ByteOrder;
import java.security.SecureRandom;

import org.bouncycastle.crypto.CryptoException;
import org.bouncycastle.crypto.PBEParametersGenerator;
import org.bouncycastle.crypto.digests.SHA1Digest;
import org.bouncycastle.crypto.engines.DESEngine;
import org.bouncycastle.crypto.generators.PKCS5S2ParametersGenerator;
import org.bouncycastle.crypto.macs.HMac;
import org.bouncycastle.crypto.modes.CBCBlockCipher;
import org.bouncycastle.crypto.paddings.PKCS7Padding;
import org.bouncycastle.crypto.paddings.PaddedBufferedBlockCipher;
import org.bouncycastle.crypto.params.KeyParameter;
import org.bouncycastle.crypto.params.ParametersWithIV;
import org.bouncycastle.util.encoders.Base64;

public class DatabaseCrypto
{
	static byte[] u2s(int[] unsignedArray) throws IOException
	{
		byte[] signedArray = new byte[unsignedArray.length];
		for (int i = 0; i < signedArray.length; i++)
		{
			if (unsignedArray[i] < 0 || unsignedArray[i] > 255)
			{
				throw new IOException("unsignedArray at " + i + " was not within the range 0 to 255.");
			}

			int subtraction = unsignedArray[i] > 128 ? 256 : 0;
			signedArray[i] = (byte) (unsignedArray[i] - subtraction);
		}

		return signedArray;
	}

	static int[] s2u(byte[] signedArray)
	{
		int[] unsignedArray = new int[signedArray.length];
		for (int i = 0; i < unsignedArray.length; i++)
		{
			int addition = signedArray[i] < 0 ? 256 : 0;
			unsignedArray[i] = (int) (signedArray[i] + addition);
		}

		return unsignedArray;
	}

	public static final String HEADER = "-------- ENCRYPTED FILE --------";

	public static class CryptoStatusWrapper
	{
		public CryptoStatus cryptoStatus;
	}

	public enum CryptoStatus
	{
		NoError, MissingHeader, VerificationFailed, DecodingError, UnsupportedVersion, UnknownError
	}

	public static String statusMessage(CryptoStatus status)
	{
		switch (status)
		{
			case MissingHeader:
				return "The file was missing its standard header.";
			case VerificationFailed:
				return "The message authentication codes were mismatched. The file may have been corrupted or tampered with.";
			case DecodingError:
				return "There was a problem decoding the file; either the password was invalid or the file may be corrupt.";
			case UnsupportedVersion:
				return "Unsupported database version.";
			case UnknownError:
				return "An unknown error occurred while decoding the file.";
			default:
				return "";
		}
	}

	public static String encrypt(String data, String password, int compressionLevel, CryptoStatusWrapper error)
	{
		try
		{
			EncryptedData encData = encrypt(password, data, compressionLevel);
			StringBuilder builder = new StringBuilder();
			builder.append(HEADER + "\n");
                        builder.append("DES\n");
			builder.append(encData.getSaltString() + "\n");
			builder.append(encData.getMACString() + "\n");
			builder.append(encData.getDataString() + "\n");
			error.cryptoStatus = CryptoStatus.NoError;
			return builder.toString();
		}
		catch (Exception e)
		{
			error.cryptoStatus = CryptoStatus.UnknownError;
			return "";
		}
	}

	public static String decrypt(String data, String password, CryptoStatusWrapper error)
	{
		try
		{
			BufferedReader2 reader = new BufferedReader2(new StringReader(data));

			// Read the actual header line and store the expected prefix
			String actualHeaderLine = reader.readLine();

			if (!actualHeaderLine.startsWith(HEADER))
			{
				error.cryptoStatus = CryptoStatus.MissingHeader;
				return "";
			}
                        
                        reader.readLine(); // AES/DES/etc

			error.cryptoStatus = CryptoStatus.NoError;
			return decrypt(password, new EncryptedData(reader.readLine(), reader.readLine(), reader.readToEnd()));
		}
		catch (MACException e)
		{
			error.cryptoStatus = CryptoStatus.VerificationFailed;
			return "";
		}
		catch (CryptoException e)
		{
			error.cryptoStatus = CryptoStatus.DecodingError;
			return "";
		}
		catch (IOException e)
		{
			error.cryptoStatus = CryptoStatus.UnknownError;
			return "";
		}
	}

	public static EncryptedData encrypt(String password, String data) throws IOException, CryptoException
	{
		return DatabaseCrypto.encrypt(password, data, -1);
	}

	public static EncryptedData encrypt(String password, String data, int compressionLevel) throws IOException, CryptoException
	{
		return (EncryptedData) DatabaseCrypto.transform(true, password, data, null, null, compressionLevel);
	}

	public static String decrypt(String password, EncryptedData data) throws IOException, CryptoException
	{
		return (String) DatabaseCrypto.transform(false, password, data.getDataString(), data.getSaltString(), data.getMACString());
	}

	public static Object transform(boolean encrypt, String password, String data, String saltString, String verificationMacString) throws IOException, CryptoException
	{
		return DatabaseCrypto.transform(encrypt, password, data, saltString, verificationMacString, -1);
	}

	public static Object transform(boolean encrypt, String password, String data, String saltString, String verificationMacString, int compressionLevel) throws IOException, CryptoException
	{
		try
		{
			final PaddedBufferedBlockCipher cipher = new PaddedBufferedBlockCipher(new CBCBlockCipher(new DESEngine()), new PKCS7Padding());

                        // was hard coded to 256 for AES
			final int keyLengthBits = 64;
			final int ivLengthBits = cipher.getBlockSize() * 8;
			final int saltLengthBytes = 8;
			final int macLengthBits = 16 * 8;
			final int keyTransformationRounds = 8192;

			final byte[] salt = encrypt ? new byte[saltLengthBytes] : Base64.decode(saltString);
			if (encrypt)
			{
				SecureRandom random = new SecureRandom();
				random.nextBytes(salt);
			}

			byte[] rawData = encrypt ? data.getBytes("UTF-8") : Base64.decode(data);

			final PBEParametersGenerator generator = new PKCS5S2ParametersGenerator();
			generator.init(PBEParametersGenerator.PKCS5PasswordToBytes(("BLK" + password).toCharArray()), salt, keyTransformationRounds);
			byte[] bcKey = ((KeyParameter) generator.generateDerivedParameters(keyLengthBits)).getKey();
			generator.init(PBEParametersGenerator.PKCS5PasswordToBytes(("IVL" + password).toCharArray()), salt, keyTransformationRounds);
			byte[] iv = ((KeyParameter) generator.generateDerivedParameters(ivLengthBits)).getKey();
			generator.init(PBEParametersGenerator.PKCS5PasswordToBytes(("MAC" + password).toCharArray()), salt, keyTransformationRounds);
			byte[] macKey = ((KeyParameter) generator.generateDerivedParameters(macLengthBits)).getKey();

			cipher.init(encrypt, new ParametersWithIV(new KeyParameter(bcKey, 0, keyLengthBits / 8), iv, 0, ivLengthBits / 8));

			// Create a byte array to hold the output data - the initial size is
			// the
			// smallest multiple of the block size greater than or equal to the
			// input length
			final byte[] processed = new byte[cipher.getOutputSize(rawData.length)];

			// Output length holds the *actual* length of the output data
			int outputLength = cipher.processBytes(rawData, 0, rawData.length, processed, 0);
			try
			{
				outputLength += cipher.doFinal(processed, outputLength);

				// Copy the output array to an array of the correct size
				// (otherwise we'll potentially have trailing null bytes)
				byte[] processedFinal = new byte[outputLength];
				System.arraycopy(processed, 0, processedFinal, 0, outputLength);

				if (encrypt)
				{
					return new EncryptedData(salt, mac(macKey, rawData), processedFinal);
				}
				else
				{
					String macString = new String(Base64.encode(mac(macKey, processedFinal)), "UTF-8");
					if (!macString.equals(verificationMacString))
					{
						throw new MACException("Unmatched MACs");
					}

					return new String(processedFinal, "UTF-8");
				}
			}
			catch (CryptoException ce)
			{
				System.err.println(ce);
				return null;
			}
		}
		catch (UnsupportedEncodingException e)
		{
			return null;
		}
	}

	private static byte[] mac(byte[] macKey, byte[] data)
	{
		HMac hmac = new HMac(new SHA1Digest());
		hmac.init(new KeyParameter(macKey));
		hmac.update(data, 0, data.length);
		byte[] mac = new byte[hmac.getMacSize()];
		hmac.doFinal(mac, 0);
		return mac;
	}
}
