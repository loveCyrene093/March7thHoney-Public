namespace March7thHoney.Kcp.KcpSharp;

public sealed class KcpRawChannelOptions
{
	public IKcpBufferPool? BufferPool { get; set; }

	public int Mtu { get; set; } = 1400;

	public int ReceiveQueueSize { get; set; } = 32;

	public int PreBufferSize { get; set; }

	public int PostBufferSize { get; set; }
}
