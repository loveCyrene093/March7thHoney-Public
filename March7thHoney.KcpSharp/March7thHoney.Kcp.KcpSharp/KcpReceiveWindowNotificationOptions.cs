using System;

namespace March7thHoney.Kcp.KcpSharp;

public sealed class KcpReceiveWindowNotificationOptions
{
	public int InitialInterval { get; }

	public int MaximumInterval { get; }

	public KcpReceiveWindowNotificationOptions(int initialInterval, int maximumInterval)
	{
		if (initialInterval <= 0)
		{
			throw new ArgumentOutOfRangeException("initialInterval");
		}
		if (maximumInterval < initialInterval)
		{
			throw new ArgumentOutOfRangeException("maximumInterval");
		}
		InitialInterval = initialInterval;
		MaximumInterval = maximumInterval;
	}
}
