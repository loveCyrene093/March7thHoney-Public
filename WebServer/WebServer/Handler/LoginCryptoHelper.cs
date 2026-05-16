using System;
using System.IO;
using System.Security.Cryptography;
using March7thHoney.Util;
using March7thHoney.Util.Security;

namespace March7thHoney.WebServer.Handler;

public static class LoginCryptoHelper
{
	private static readonly Logger Logger = new Logger("LoginCrypto");

	private static string SecurityDir => Path.Combine(ConfigManager.Config.Path.ConfigPath, "Security");

	private static string PrivateKeyPath => Path.Combine(SecurityDir, "LoginRsaPrivateKey.pem");

	public static (string account, string password) TryDecryptCredentials(string? account, string? password, bool decryptRequested)
	{
		string text = account ?? string.Empty;
		string text2 = password ?? string.Empty;
		if (!decryptRequested)
		{
			return (account: text, password: text2);
		}
		string text3 = LoadPrivateKey();
		if (string.IsNullOrWhiteSpace(text3))
		{
			return (account: text, password: text2);
		}
		text3 = NormalizePem(text3);
		return (account: TryDecrypt(text, text3), password: TryDecrypt(text2, text3));
	}

	private static string TryDecrypt(string raw, string privatePem)
	{
		if (string.IsNullOrWhiteSpace(raw))
		{
			return raw;
		}
		if (!LooksLikeBase64(raw))
		{
			return raw;
		}
		RSAEncryptionPadding[] array = new RSAEncryptionPadding[3]
		{
			RSAEncryptionPadding.Pkcs1,
			RSAEncryptionPadding.OaepSHA1,
			RSAEncryptionPadding.OaepSHA256
		};
		RSAEncryptionPadding[] array2 = array;
		foreach (RSAEncryptionPadding rSAEncryptionPadding in array2)
		{
			try
			{
				return March7thHoney.Util.Security.RSA.DecryptFromBase64(raw, privatePem, null, rSAEncryptionPadding);
			}
			catch (Exception e)
			{
				Logger.Debug($"RSA login decrypt with {rSAEncryptionPadding.Mode} failed, fallback next. len={raw.Length}", e);
			}
		}
		Logger.Debug($"RSA login decrypt failed for all paddings, fallback plaintext. len={raw.Length}");
		return raw;
	}

	private static bool LooksLikeBase64(string value)
	{
		if (value.Length < 16 || value.Length % 4 != 0)
		{
			return false;
		}
		int bytesWritten;
		return Convert.TryFromBase64String(value, new Span<byte>(new byte[value.Length]), out bytesWritten);
	}

	private static string NormalizePem(string pem)
	{
		string text = pem.Replace("\\n", "\n").Trim();
		if (!text.Contains("BEGIN", StringComparison.OrdinalIgnoreCase))
		{
			text = "-----BEGIN RSA PRIVATE KEY-----\n" + text + "\n-----END RSA PRIVATE KEY-----";
		}
		return text;
	}

	private static string LoadPrivateKey()
	{
		try
		{
			if (File.Exists(PrivateKeyPath))
			{
				return File.ReadAllText(PrivateKeyPath).Trim();
			}
		}
		catch (Exception e)
		{
			Logger.Debug("Load private key from file failed: " + PrivateKeyPath, e);
		}
		return ConfigManager.Config.WebSecurity.RsaPrivateKeyPem;
	}
}
