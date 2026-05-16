using System;
using System.Globalization;

namespace March7thHoney.Kcp.KcpSharp;

public readonly struct KcpConversationReceiveResult : IEquatable<KcpConversationReceiveResult>
{
	private readonly bool _connectionAlive;

	public int BytesReceived { get; }

	public bool TransportClosed => !_connectionAlive;

	public KcpConversationReceiveResult(int bytesReceived)
	{
		BytesReceived = bytesReceived;
		_connectionAlive = true;
	}

	public static bool operator ==(KcpConversationReceiveResult left, KcpConversationReceiveResult right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(KcpConversationReceiveResult left, KcpConversationReceiveResult right)
	{
		return !left.Equals(right);
	}

	public bool Equals(KcpConversationReceiveResult other)
	{
		if (BytesReceived == other.BytesReceived)
		{
			return TransportClosed == other.TransportClosed;
		}
		return false;
	}

	public override bool Equals(object? obj)
	{
		if (obj is KcpConversationReceiveResult other)
		{
			return Equals(other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return HashCode.Combine(BytesReceived, TransportClosed);
	}

	public override string ToString()
	{
		if (!_connectionAlive)
		{
			return "Transport is closed.";
		}
		return BytesReceived.ToString(CultureInfo.InvariantCulture);
	}
}
