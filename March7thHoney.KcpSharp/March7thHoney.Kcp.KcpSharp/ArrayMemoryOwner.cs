using System;
using System.Buffers;

namespace March7thHoney.Kcp.KcpSharp;

internal sealed class ArrayMemoryOwner : IMemoryOwner<byte>, IDisposable
{
	private readonly byte[] _buffer;

	public Memory<byte> Memory => _buffer;

	public ArrayMemoryOwner(byte[] buffer)
	{
		_buffer = buffer ?? throw new ArgumentNullException("buffer");
	}

	public void Dispose()
	{
	}
}
