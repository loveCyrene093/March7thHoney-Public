using System;
using System.Buffers.Binary;

namespace March7thHoney.Kcp.KcpSharp;

internal readonly struct KcpPacketHeader : IEquatable<KcpPacketHeader>
{
	public KcpCommand Command { get; }

	public byte Fragment { get; }

	public ushort WindowSize { get; }

	public uint Timestamp { get; }

	public uint SerialNumber { get; }

	public uint Unacknowledged { get; }

	public KcpPacketHeader(KcpCommand command, byte fragment, ushort windowSize, uint timestamp, uint serialNumber, uint unacknowledged)
	{
		Command = command;
		Fragment = fragment;
		WindowSize = windowSize;
		Timestamp = timestamp;
		SerialNumber = serialNumber;
		Unacknowledged = unacknowledged;
	}

	internal KcpPacketHeader(byte fragment)
	{
		Command = (KcpCommand)0;
		Fragment = fragment;
		WindowSize = 0;
		Timestamp = 0u;
		SerialNumber = 0u;
		Unacknowledged = 0u;
	}

	public bool Equals(KcpPacketHeader other)
	{
		if (Command == other.Command && Fragment == other.Fragment && WindowSize == other.WindowSize && Timestamp == other.Timestamp && SerialNumber == other.SerialNumber)
		{
			return Unacknowledged == other.Unacknowledged;
		}
		return false;
	}

	public override bool Equals(object? obj)
	{
		if (obj is KcpPacketHeader other)
		{
			return Equals(other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return HashCode.Combine(Command, Fragment, WindowSize, Timestamp, SerialNumber, Unacknowledged);
	}

	public static KcpPacketHeader Parse(ReadOnlySpan<byte> buffer)
	{
		return new KcpPacketHeader((KcpCommand)buffer[0], buffer[1], BinaryPrimitives.ReadUInt16LittleEndian(buffer.Slice(2)), BinaryPrimitives.ReadUInt32LittleEndian(buffer.Slice(4)), BinaryPrimitives.ReadUInt32LittleEndian(buffer.Slice(8)), BinaryPrimitives.ReadUInt32LittleEndian(buffer.Slice(12)));
	}

	internal void EncodeHeader(ulong? conversationId, int payloadLength, Span<byte> destination, out int bytesWritten)
	{
		if (conversationId.HasValue)
		{
			BinaryPrimitives.WriteUInt64BigEndian(destination, conversationId.GetValueOrDefault());
			destination = destination.Slice(8);
			bytesWritten = 28;
		}
		else
		{
			bytesWritten = 20;
		}
		destination[1] = Fragment;
		destination[0] = (byte)Command;
		BinaryPrimitives.WriteUInt16LittleEndian(destination.Slice(2), WindowSize);
		BinaryPrimitives.WriteUInt32LittleEndian(destination.Slice(4), Timestamp);
		BinaryPrimitives.WriteUInt32LittleEndian(destination.Slice(8), SerialNumber);
		BinaryPrimitives.WriteUInt32LittleEndian(destination.Slice(12), Unacknowledged);
		BinaryPrimitives.WriteUInt32LittleEndian(destination.Slice(16), (uint)payloadLength);
	}
}
