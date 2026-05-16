namespace March7thHoney.Kcp.KcpSharp;

internal enum KcpCommand : byte
{
	Push = 81,
	Ack,
	WindowProbe,
	WindowSize
}
