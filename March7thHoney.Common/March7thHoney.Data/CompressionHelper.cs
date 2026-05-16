using System;
using System.IO;
using System.IO.Compression;

namespace March7thHoney.Data;

public static class CompressionHelper
{
	public static byte[] Compress(byte[] data)
	{
		ArgumentNullException.ThrowIfNull(data, "data");
		if (data.Length == 0)
		{
			return Array.Empty<byte>();
		}
		try
		{
			if (data.Length < 1024)
			{
				byte[] array = new byte[data.Length + 1];
				array[0] = 0;
				Buffer.BlockCopy(data, 0, array, 1, data.Length);
				return array;
			}
			using MemoryStream memoryStream = new MemoryStream();
			memoryStream.WriteByte(1);
			using (DeflateStream deflateStream = new DeflateStream(memoryStream, CompressionMode.Compress, leaveOpen: true))
			{
				deflateStream.Write(data, 0, data.Length);
			}
			return memoryStream.ToArray();
		}
		catch
		{
			byte[] array2 = new byte[data.Length + 1];
			array2[0] = 0;
			Buffer.BlockCopy(data, 0, array2, 1, data.Length);
			return array2;
		}
	}

	public static byte[] Decompress(byte[] data)
	{
		ArgumentNullException.ThrowIfNull(data, "data");
		if (data.Length == 0)
		{
			return Array.Empty<byte>();
		}
		try
		{
			if (data[0] == 0)
			{
				byte[] array = new byte[data.Length - 1];
				Buffer.BlockCopy(data, 1, array, 0, array.Length);
				return array;
			}
			using MemoryStream stream = new MemoryStream(data, 1, data.Length - 1);
			using DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
			using MemoryStream memoryStream = new MemoryStream();
			deflateStream.CopyTo(memoryStream);
			return memoryStream.ToArray();
		}
		catch
		{
			return data;
		}
	}
}
