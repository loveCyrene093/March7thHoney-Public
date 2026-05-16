namespace March7thHoney.Kcp.KcpSharp;

internal readonly struct KcpSendSegmentStats(uint resendTimestamp, uint rto, uint fastAck, uint transmitCount)
{
	public uint ResendTimestamp { get; } = resendTimestamp;

	public uint Rto { get; } = rto;

	public uint FastAck { get; } = fastAck;

	public uint TransmitCount { get; } = transmitCount;
}
