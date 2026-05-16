using System;

namespace March7thHoney.Kcp.KcpSharp;

public sealed class KcpKeepAliveOptions
{
	internal int SendInterval { get; }

	internal int GracePeriod { get; }

	public KcpKeepAliveOptions(int sendInterval, int gracePeriod)
	{
		if (sendInterval <= 0)
		{
			throw new ArgumentOutOfRangeException("sendInterval");
		}
		if (gracePeriod <= 0)
		{
			throw new ArgumentOutOfRangeException("gracePeriod");
		}
		SendInterval = sendInterval;
		GracePeriod = gracePeriod;
	}
}
