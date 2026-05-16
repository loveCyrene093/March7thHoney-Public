using System;
using System.Buffers.Binary;
using System.Collections.Generic;

namespace March7thHoney.Util.Security;

public class Ec2b
{
	private const int HEAD_MAGIC = 1647469381;

	private const int KEY_SIZE = 16;

	private const int DATA_SIZE = 2048;

	private readonly byte[] Data;

	private readonly byte[] Key;

	private ulong Seed;

	private byte[] XorKey;

	private Ec2b(byte[] key, byte[] data)
	{
		Key = key;
		Data = data;
		byte[] array = new byte[16];
		Array.Copy(Key, array, 16);
		KeyScramble(array);
		GenerateDecryptionVector(array, Data);
	}

	public static Ec2b Read(byte[] input)
	{
		if (input == null || input.Length < 2076)
		{
			throw new Exception("Input data is too short.");
		}
		int num = 0;
		int num2 = BinaryPrimitives.ReadInt32LittleEndian(input.AsSpan(num, 4));
		if (num2 != 1647469381)
		{
			throw new Exception($"Magic mismatch, expected: {1647469381}, got: {num2}");
		}
		num += 4;
		int num3 = BinaryPrimitives.ReadInt32LittleEndian(input.AsSpan(num, 4));
		num += 4;
		if (num3 != 16)
		{
			throw new Exception($"Invalid key size, expected: {16}, got: {num3}");
		}
		if (input.Length < num + 16)
		{
			throw new Exception("Input data is too short for key.");
		}
		byte[] array = new byte[16];
		Array.Copy(input, num, array, 0, 16);
		num += 16;
		if (input.Length < num + 4)
		{
			throw new Exception("Input data is too short for data size.");
		}
		int num4 = BinaryPrimitives.ReadInt32LittleEndian(input.AsSpan(num, 4));
		num += 4;
		if (num4 != 2048)
		{
			throw new Exception($"Invalid data size, expected: {2048}, got: {num4}");
		}
		if (input.Length < num + 2048)
		{
			throw new Exception("Input data is too short for data.");
		}
		byte[] array2 = new byte[2048];
		Array.Copy(input, num, array2, 0, 2048);
		return new Ec2b(array, array2);
	}

	public static Ec2b GenerateEc2b()
	{
		byte[] array = new byte[16];
		byte[] array2 = new byte[2048];
		MT19937 mT = new MT19937((ulong)DateTimeOffset.UtcNow.ToUnixTimeSeconds());
		for (int i = 0; i < 16; i++)
		{
			array[i] = (byte)(mT.NextUInt64() % 256);
		}
		for (int j = 0; j < 2048; j++)
		{
			array2[j] = (byte)(mT.NextUInt64() % 256);
		}
		return new Ec2b(array, array2);
	}

	public byte[] GetBytes()
	{
		byte[] array = new byte[2076];
		int num = 0;
		BinaryPrimitives.WriteInt32LittleEndian(array.AsSpan(num, 4), 1647469381);
		num += 4;
		BinaryPrimitives.WriteInt32LittleEndian(array.AsSpan(num, 4), 16);
		num += 4;
		Array.Copy(Key, 0, array, num, 16);
		num += 16;
		BinaryPrimitives.WriteInt32LittleEndian(array.AsSpan(num, 4), 2048);
		num += 4;
		Array.Copy(Data, 0, array, num, 2048);
		return array;
	}

	public ulong GetSeed()
	{
		return Seed;
	}

	public byte[] GetXorKey()
	{
		return XorKey;
	}

	private void GenerateDecryptionVector(byte[] key, byte[] crypt)
	{
		List<byte> list = new List<byte>(4096);
		ulong num = ulong.MaxValue;
		for (int i = 0; i < crypt.Length; i += 8)
		{
			ulong num2 = BitConverter.ToUInt64(crypt, i);
			num ^= num2;
		}
		ulong num3 = BitConverter.ToUInt64(key, 0);
		ulong num4 = BitConverter.ToUInt64(key, 8);
		Seed = num4 ^ 0xCEAC3B5A867837ACuL ^ num ^ num3;
		MT19937 mT = new MT19937(Seed);
		for (int j = 0; j < 512; j++)
		{
			byte[] bytes = BitConverter.GetBytes(mT.NextUInt64());
			list.AddRange(bytes);
		}
		XorKey = list.ToArray();
	}

	private static void KeyScramble(byte[] key)
	{
		byte[] array = new byte[176];
		for (int i = 0; i < 11; i++)
		{
			for (int j = 0; j < 16; j++)
			{
				for (int k = 0; k < 16; k++)
				{
					int num = (i << 8) + j * 16 + k;
					array[i * 16 + j] ^= (byte)(Magic.aesXorTable[1, num] ^ Magic.aesXorTable[0, num]);
				}
			}
		}
		byte[] array2 = new byte[16];
		AES128.RevAes128Enc(key, array, array2);
		for (int l = 0; l < 16; l++)
		{
			array2[l] ^= Magic.keyXorTable[l];
		}
		Array.Copy(array2, key, 16);
	}
}
