using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using March7thHoney.Proto;
using March7thHoney.Proto.ServerSide;
using Newtonsoft.Json;

namespace March7thHoney.Util;

public static class Extensions
{
	public static Position ToPosition(this Vector vector)
	{
		return new Position
		{
			X = vector.X,
			Y = vector.Y,
			Z = vector.Z
		};
	}

	public static Position ToPosition(this Vector3Pb vector)
	{
		return new Position
		{
			X = vector.X,
			Y = vector.Y,
			Z = vector.Z
		};
	}

	public static Vector ToVector(this Position position)
	{
		return new Vector
		{
			X = position.X,
			Y = position.Y,
			Z = position.Z
		};
	}

	public static Vector3Pb ToVector3Pb(this Position position)
	{
		return new Vector3Pb
		{
			X = position.X,
			Y = position.Y,
			Z = position.Z
		};
	}

	public static T RandomElement<T>(this List<T> values)
	{
		int index = new Random().Next(values.Count);
		return values[index];
	}

	public static ICollection<T> Clone<T>(this ICollection<T> values)
	{
		return values.ToList();
	}

	public static int RandomInt(int from, int to)
	{
		return new Random().Next(from, to);
	}

	public static void SafeAdd<T>(this List<T> list, T item)
	{
		if (!list.Contains(item))
		{
			list.Add(item);
		}
	}

	public static void SafeAddRange<T>(this List<T> list, List<T> item)
	{
		foreach (T item2 in item)
		{
			list.SafeAdd(item2);
		}
	}

	public static long GetUnixSec()
	{
		return DateTimeOffset.UtcNow.ToUnixTimeSeconds();
	}

	public static long ToUnixSec(this DateTime dt)
	{
		return new DateTimeOffset(dt).ToUnixTimeSeconds();
	}

	public static long GetUnixMs()
	{
		return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
	}

	public static string ToArrayString<T>(this List<T> list)
	{
		return list.JoinFormat(", ", "");
	}

	public static string ToJsonString<TK, TV>(this Dictionary<TK, TV> dic) where TK : notnull
	{
		return JsonConvert.SerializeObject(dic);
	}

	public static string JoinFormat<T>(this IEnumerable<T> list, string separator, string formatString)
	{
		formatString = (string.IsNullOrWhiteSpace(formatString) ? "{0}" : formatString);
		return string.Join(separator, list.Select((T item) => string.Format(formatString, item)));
	}

	public static void WriteConvID(this BinaryWriter bw, long convId)
	{
		bw.Write((int)(convId >> 32));
		bw.Write((int)(convId & 0xFFFFFFFFu));
	}

	public static long GetNextAvailableIndex<T>(this SortedList<long, T> sortedList)
	{
		long num = 1L;
		long num2 = sortedList.Count;
		long num3 = 0L;
		while (num2 != 0L)
		{
			long num4 = ((IEnumerable<long>)sortedList.Keys).ElementAt((Index)(int)num3++);
			if (num != num4)
			{
				break;
			}
			num = num4 + 1;
			if (num2 == 1 || num3 == num2 || num != ((IEnumerable<long>)sortedList.Keys).ElementAt((Index)(int)num3))
			{
				break;
			}
		}
		return num;
	}

	public static long AddNext<T>(this SortedList<long, T> sortedList, T item)
	{
		long nextAvailableIndex = sortedList.GetNextAvailableIndex();
		sortedList.Add(nextAvailableIndex, item);
		return nextAvailableIndex;
	}

	public static int ReadInt32BE(this BinaryReader br)
	{
		return BinaryPrimitives.ReadInt32BigEndian(br.ReadBytes(4));
	}

	public static uint ReadUInt32BE(this BinaryReader br)
	{
		return BinaryPrimitives.ReadUInt32BigEndian(br.ReadBytes(4));
	}

	public static ushort ReadUInt16BE(this BinaryReader br)
	{
		return BinaryPrimitives.ReadUInt16BigEndian(br.ReadBytes(2));
	}

	public static void WriteUInt16BE(this BinaryWriter bw, ushort value)
	{
		Span<byte> span = stackalloc byte[2];
		BinaryPrimitives.WriteUInt16BigEndian(span, value);
		bw.Write(span);
	}

	public static void WriteInt32BE(this BinaryWriter bw, int value)
	{
		Span<byte> span = stackalloc byte[4];
		BinaryPrimitives.WriteInt32BigEndian(span, value);
		bw.Write(span);
	}

	public static void WriteUInt32BE(this BinaryWriter bw, uint value)
	{
		Span<byte> span = stackalloc byte[4];
		BinaryPrimitives.WriteUInt32BigEndian(span, value);
		bw.Write(span);
	}

	public static void WriteUInt64BE(this BinaryWriter bw, ulong value)
	{
		Span<byte> span = stackalloc byte[8];
		BinaryPrimitives.WriteUInt64BigEndian(span, value);
		bw.Write(span);
	}
}
