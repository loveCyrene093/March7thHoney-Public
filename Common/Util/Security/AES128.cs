using System;
using System.Linq;

namespace March7thHoney.Util.Security;

public class AES128
{
	private static void Xor(byte[] a, byte[] b, int n)
	{
		for (int i = 0; i < n; i++)
		{
			a[i] ^= b[i];
		}
	}

	private static void XorRoundKey(byte[] state, byte[] keys, int round)
	{
		Xor(state, keys.Skip(round * 16).Take(16).ToArray(), 16);
	}

	private static void SubBytes(byte[] a, int n)
	{
		for (int i = 0; i < n; i++)
		{
			a[i] = Magic.LookupSbox[a[i]];
		}
	}

	private static void SubBytesInv(byte[] a, int n)
	{
		for (int i = 0; i < n; i++)
		{
			a[i] = Magic.LookupSboxInv[a[i]];
		}
	}

	private static void KeyScheduleCore(byte[] a, int i)
	{
		byte b = a[0];
		a[0] = a[1];
		a[1] = a[2];
		a[2] = a[3];
		a[3] = b;
		SubBytes(a, 4);
		a[0] ^= Magic.LookupRcon[i];
	}

	public static void Aes128LoadSchedule(byte[] key, out byte[] schedule)
	{
		schedule = new byte[176];
		int num = 16;
		int num2 = 1;
		byte[] array = new byte[4];
		Array.Copy(key, schedule, 16);
		while (num < 176)
		{
			Array.Copy(schedule, num - 4, array, 0, 4);
			KeyScheduleCore(array, num2);
			num2++;
			for (int i = 0; i < 4; i++)
			{
				array[i] ^= schedule[num - 16 + i];
			}
			Array.Copy(array, 0, schedule, num, 4);
			num += 4;
			for (int j = 0; j < 3; j++)
			{
				Array.Copy(schedule, num - 4, array, 0, 4);
				for (int k = 0; k < 4; k++)
				{
					array[k] ^= schedule[num - 16 + k];
				}
				Array.Copy(array, 0, schedule, num, 4);
				num += 4;
			}
		}
	}

	private static void ShiftRows(byte[] state)
	{
		byte[] array = new byte[16];
		Array.Copy(state, array, 16);
		for (int i = 0; i < 16; i++)
		{
			state[i] = array[Magic.ShiftRowsTable[i]];
		}
	}

	private static void ShiftRowsInv(byte[] state)
	{
		byte[] array = new byte[16];
		Array.Copy(state, array, 16);
		for (int i = 0; i < 16; i++)
		{
			state[i] = array[Magic.ShiftRowsTableInv[i]];
		}
	}

	private static void MixCol(byte[] state, int offset)
	{
		byte b = state[offset];
		byte b2 = state[offset + 1];
		byte b3 = state[offset + 2];
		byte b4 = state[offset + 3];
		state[offset] = (byte)(Magic.LookupG2[b] ^ Magic.LookupG3[b2] ^ b3 ^ b4);
		state[offset + 1] = (byte)(Magic.LookupG2[b2] ^ Magic.LookupG3[b3] ^ b4 ^ b);
		state[offset + 2] = (byte)(Magic.LookupG2[b3] ^ Magic.LookupG3[b4] ^ b ^ b2);
		state[offset + 3] = (byte)(Magic.LookupG2[b4] ^ Magic.LookupG3[b] ^ b2 ^ b3);
	}

	private static void MixCols(byte[] state)
	{
		MixCol(state, 0);
		MixCol(state, 4);
		MixCol(state, 8);
		MixCol(state, 12);
	}

	private static void MixColInv(byte[] state, int offset)
	{
		byte b = state[offset];
		byte b2 = state[offset + 1];
		byte b3 = state[offset + 2];
		byte b4 = state[offset + 3];
		state[offset] = (byte)(Magic.LookupG14[b] ^ Magic.LookupG9[b4] ^ Magic.LookupG13[b3] ^ Magic.LookupG11[b2]);
		state[offset + 1] = (byte)(Magic.LookupG14[b2] ^ Magic.LookupG9[b] ^ Magic.LookupG13[b4] ^ Magic.LookupG11[b3]);
		state[offset + 2] = (byte)(Magic.LookupG14[b3] ^ Magic.LookupG9[b2] ^ Magic.LookupG13[b] ^ Magic.LookupG11[b4]);
		state[offset + 3] = (byte)(Magic.LookupG14[b4] ^ Magic.LookupG9[b3] ^ Magic.LookupG13[b2] ^ Magic.LookupG11[b]);
	}

	private static void MixColsInv(byte[] state)
	{
		MixColInv(state, 0);
		MixColInv(state, 4);
		MixColInv(state, 8);
		MixColInv(state, 12);
	}

	public static void Aes128Enc(byte[] plaintext, byte[] schedule, byte[] ciphertext)
	{
		Array.Copy(plaintext, ciphertext, 16);
		XorRoundKey(ciphertext, schedule, 0);
		for (int i = 0; i < 9; i++)
		{
			SubBytes(ciphertext, 16);
			ShiftRows(ciphertext);
			MixCols(ciphertext);
			XorRoundKey(ciphertext, schedule, i + 1);
		}
		SubBytes(ciphertext, 16);
		ShiftRows(ciphertext);
		XorRoundKey(ciphertext, schedule, 10);
	}

	public static void RevAes128Enc(byte[] plaintext, byte[] schedule, byte[] ciphertext)
	{
		Array.Copy(plaintext, ciphertext, 16);
		XorRoundKey(ciphertext, schedule, 0);
		for (int i = 0; i < 9; i++)
		{
			SubBytesInv(ciphertext, 16);
			ShiftRowsInv(ciphertext);
			MixColsInv(ciphertext);
			XorRoundKey(ciphertext, schedule, i + 1);
		}
		SubBytesInv(ciphertext, 16);
		ShiftRowsInv(ciphertext);
		XorRoundKey(ciphertext, schedule, 10);
	}

	public static void Aes128Dec(byte[] ciphertext, byte[] schedule, byte[] plaintext)
	{
		Array.Copy(ciphertext, plaintext, 16);
		XorRoundKey(plaintext, schedule, 10);
		ShiftRowsInv(plaintext);
		SubBytesInv(plaintext, 16);
		for (int i = 0; i < 9; i++)
		{
			XorRoundKey(plaintext, schedule, 9 - i);
			MixColsInv(plaintext);
			ShiftRowsInv(plaintext);
			SubBytesInv(plaintext, 16);
		}
		XorRoundKey(plaintext, schedule, 0);
	}

	public static void RevAes128Dec(byte[] ciphertext, byte[] schedule, byte[] plaintext)
	{
		Array.Copy(ciphertext, plaintext, 16);
		XorRoundKey(plaintext, schedule, 10);
		ShiftRows(plaintext);
		SubBytes(plaintext, 16);
		for (int i = 0; i < 9; i++)
		{
			XorRoundKey(plaintext, schedule, 9 - i);
			MixCols(plaintext);
			ShiftRows(plaintext);
			SubBytes(plaintext, 16);
		}
		XorRoundKey(plaintext, schedule, 0);
	}
}
