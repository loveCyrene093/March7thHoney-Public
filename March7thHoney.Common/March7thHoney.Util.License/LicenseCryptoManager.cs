using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace March7thHoney.Util.License;

public static class LicenseCryptoManager
{
	private const string Prefix = "M7H1:";

	private static readonly byte[] Key = SHA256.HashData(Encoding.UTF8.GetBytes("March7thHoney.Public.License.Internal.Key"));

	public static string Decrypt(string text)
	{
		if (string.IsNullOrWhiteSpace(text))
		{
			throw new InvalidOperationException("Empty License text.");
		}
		string text2 = text.Trim();
		if (text2.StartsWith("M7H1:", StringComparison.Ordinal))
		{
			return DecryptAes(text2.Substring("M7H1:".Length));
		}
		string text3 = Encoding.UTF8.GetString(Convert.FromBase64String(text2));
		if (text3.TrimStart().StartsWith("{", StringComparison.Ordinal))
		{
			return text3;
		}
		return DecryptAes(text2);
	}

	private static string DecryptAes(string base64)
	{
		byte[] array = Convert.FromBase64String(base64);
		if (array.Length <= 16)
		{
			throw new InvalidOperationException("Invalid License payload.");
		}
		byte[] iV = array.Take(16).ToArray();
		byte[] subArray = array[16..];
		using Aes aes = Aes.Create();
		aes.Key = Key;
		aes.IV = iV;
		aes.Mode = CipherMode.CBC;
		aes.Padding = PaddingMode.PKCS7;
		using ICryptoTransform cryptoTransform = aes.CreateDecryptor();
		byte[] bytes = cryptoTransform.TransformFinalBlock(subArray, 0, subArray.Length);
		return Encoding.UTF8.GetString(bytes);
	}
}
