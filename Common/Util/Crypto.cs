using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using March7thHoney.Internationalization;
using March7thHoney.Util.Security;

namespace March7thHoney.Util;

public class Crypto
{
	private static readonly Random SecureRandom = new Random();

	public static Logger Logger = new Logger("Crypto");

	public static Ec2b? ClientSecretKey { get; set; }

	public static void Xor(byte[] packet, byte[] key)
	{
		try
		{
			for (int i = 0; i < packet.Length; i++)
			{
				packet[i] ^= key[i % key.Length];
			}
		}
		catch (Exception e)
		{
			Logger.Error("Crypto error.", e);
		}
	}

	public static byte[] GenerateXorKey(ulong seed)
	{
		byte[] array = new byte[4096];
		MT19937 mT = new MT19937(seed);
		for (int i = 0; i < array.Length / 8; i++)
		{
			ulong num = mT.NextUInt64();
			array[i * 8] = (byte)((num >> 56) & 0xFF);
			array[i * 8 + 1] = (byte)((num >> 48) & 0xFF);
			array[i * 8 + 2] = (byte)((num >> 40) & 0xFF);
			array[i * 8 + 3] = (byte)((num >> 32) & 0xFF);
			array[i * 8 + 4] = (byte)((num >> 24) & 0xFF);
			array[i * 8 + 5] = (byte)((num >> 16) & 0xFF);
			array[i * 8 + 6] = (byte)((num >> 8) & 0xFF);
			array[i * 8 + 7] = (byte)(num & 0xFF);
		}
		return array;
	}

	public static Ec2b? InitEc2b()
	{
		string path = ConfigManager.Config.Path.ConfigPath + "/ClientSecretKey.ec2b";
		try
		{
			byte[] bytes;
			if (!File.Exists(path))
			{
				Ec2b ec2b = Ec2b.GenerateEc2b();
				bytes = ec2b.GetBytes();
				File.WriteAllBytes(path, bytes);
				Logger.Info(I18NManager.Translate("Server.ServerInfo.NewClientSecretKey"));
				return ec2b;
			}
			bytes = File.ReadAllBytes(path);
			return Ec2b.Read(bytes);
		}
		catch (Exception value)
		{
			Logger.Error($"An error occurred while loading the Client Secret Key：{value}");
			return null;
		}
	}

	public static string CreateSessionKey(string accountUid)
	{
		byte[] buffer = new byte[64];
		SecureRandom.NextBytes(buffer);
		string s = accountUid + "." + DateTime.Now.Ticks + "." + SecureRandom;
		try
		{
			return Convert.ToBase64String(SHA512.HashData(Encoding.UTF8.GetBytes(s)));
		}
		catch
		{
			return Convert.ToBase64String(SHA512.HashData(Encoding.UTF8.GetBytes(s)));
		}
	}
}
