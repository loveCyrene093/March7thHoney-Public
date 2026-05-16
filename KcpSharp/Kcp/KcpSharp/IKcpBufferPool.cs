namespace March7thHoney.Kcp.KcpSharp;

public interface IKcpBufferPool
{
	KcpRentedBuffer Rent(KcpBufferPoolRentOptions options);
}
