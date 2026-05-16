using System;

namespace March7thHoney.Kcp.KcpSharp;

public readonly struct KcpBufferPoolRentOptions : IEquatable<KcpBufferPoolRentOptions>
{
	public int Size { get; }

	public bool IsOutbound { get; }

	public KcpBufferPoolRentOptions(int size, bool isOutbound)
	{
		Size = size;
		IsOutbound = isOutbound;
	}

	public bool Equals(KcpBufferPoolRentOptions other)
	{
		if (Size == other.Size)
		{
			return IsOutbound == other.IsOutbound;
		}
		return false;
	}

	public override bool Equals(object? obj)
	{
		if (obj is KcpBufferPoolRentOptions other)
		{
			return Equals(other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return HashCode.Combine(Size, IsOutbound);
	}
}
