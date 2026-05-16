using System;
using System.Security.Cryptography;
using System.Text;

namespace March7thHoney.Util.Security;

public static class RSA
{
	public static (string PublicKeyPem, string PrivateKeyPem) GenerateKeyPair(int keySize = 2048)
	{
		using System.Security.Cryptography.RSA rSA = System.Security.Cryptography.RSA.Create(keySize);
		string item = rSA.ExportRSAPublicKeyPem();
		string item2 = rSA.ExportRSAPrivateKeyPem();
		return (PublicKeyPem: item, PrivateKeyPem: item2);
	}

	public static byte[] Encrypt(byte[] plainBytes, string publicKeyPem, RSAEncryptionPadding? padding = null)
	{
		ArgumentNullException.ThrowIfNull(plainBytes, "plainBytes");
		ArgumentException.ThrowIfNullOrWhiteSpace(publicKeyPem, "publicKeyPem");
		using System.Security.Cryptography.RSA rSA = System.Security.Cryptography.RSA.Create();
		rSA.ImportFromPem(publicKeyPem.AsSpan());
		return rSA.Encrypt(plainBytes, padding ?? RSAEncryptionPadding.Pkcs1);
	}

	public static byte[] Decrypt(byte[] cipherBytes, string privateKeyPem, RSAEncryptionPadding? padding = null)
	{
		ArgumentNullException.ThrowIfNull(cipherBytes, "cipherBytes");
		ArgumentException.ThrowIfNullOrWhiteSpace(privateKeyPem, "privateKeyPem");
		using System.Security.Cryptography.RSA rSA = System.Security.Cryptography.RSA.Create();
		rSA.ImportFromPem(privateKeyPem.AsSpan());
		return rSA.Decrypt(cipherBytes, padding ?? RSAEncryptionPadding.Pkcs1);
	}

	public static string EncryptToBase64(string plainText, string publicKeyPem, Encoding? encoding = null, RSAEncryptionPadding? padding = null)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(plainText, "plainText");
		if (encoding == null)
		{
			encoding = Encoding.UTF8;
		}
		return Convert.ToBase64String(Encrypt(encoding.GetBytes(plainText), publicKeyPem, padding));
	}

	public static string DecryptFromBase64(string cipherBase64, string privateKeyPem, Encoding? encoding = null, RSAEncryptionPadding? padding = null)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(cipherBase64, "cipherBase64");
		if (encoding == null)
		{
			encoding = Encoding.UTF8;
		}
		byte[] bytes = Decrypt(Convert.FromBase64String(cipherBase64), privateKeyPem, padding);
		return encoding.GetString(bytes);
	}

	public static byte[] Sign(byte[] data, string privateKeyPem, HashAlgorithmName? hashAlgorithm = null, RSASignaturePadding? padding = null)
	{
		ArgumentNullException.ThrowIfNull(data, "data");
		ArgumentException.ThrowIfNullOrWhiteSpace(privateKeyPem, "privateKeyPem");
		using System.Security.Cryptography.RSA rSA = System.Security.Cryptography.RSA.Create();
		rSA.ImportFromPem(privateKeyPem.AsSpan());
		return rSA.SignData(data, hashAlgorithm ?? HashAlgorithmName.SHA256, padding ?? RSASignaturePadding.Pkcs1);
	}

	public static bool Verify(byte[] data, byte[] signature, string publicKeyPem, HashAlgorithmName? hashAlgorithm = null, RSASignaturePadding? padding = null)
	{
		ArgumentNullException.ThrowIfNull(data, "data");
		ArgumentNullException.ThrowIfNull(signature, "signature");
		ArgumentException.ThrowIfNullOrWhiteSpace(publicKeyPem, "publicKeyPem");
		using System.Security.Cryptography.RSA rSA = System.Security.Cryptography.RSA.Create();
		rSA.ImportFromPem(publicKeyPem.AsSpan());
		return rSA.VerifyData(data, signature, hashAlgorithm ?? HashAlgorithmName.SHA256, padding ?? RSASignaturePadding.Pkcs1);
	}
}
