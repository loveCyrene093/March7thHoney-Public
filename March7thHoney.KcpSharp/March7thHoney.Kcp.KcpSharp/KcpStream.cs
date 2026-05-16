using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace March7thHoney.Kcp.KcpSharp;

public sealed class KcpStream : Stream
{
	private readonly bool _ownsConversation;

	private KcpConversation? _conversation;

	public override bool CanRead => true;

	public override bool CanSeek => false;

	public override bool CanWrite => true;

	public override long Length
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	public override long Position
	{
		get
		{
			throw new NotSupportedException();
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public bool DataAvailable
	{
		get
		{
			if (_conversation == null)
			{
				ThrowHelper.ThrowObjectDisposedForKcpStreamException();
			}
			if (_conversation.TryPeek(out var result))
			{
				return result.BytesReceived != 0;
			}
			return false;
		}
	}

	public KcpStream(KcpConversation conversation, bool ownsConversation)
	{
		if (conversation == null)
		{
			throw new ArgumentNullException("conversation");
		}
		if (!conversation.StreamMode)
		{
			throw new ArgumentException("Non-stream mode conversation is not supported.", "conversation");
		}
		_conversation = conversation;
		_ownsConversation = ownsConversation;
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException();
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException();
	}

	public override void Flush()
	{
		throw new NotSupportedException();
	}

	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		if (_conversation == null)
		{
			return Task.FromException(ThrowHelper.NewObjectDisposedForKcpStreamException());
		}
		return _conversation.FlushAsync(cancellationToken).AsTask();
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException();
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException();
	}

	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		if (_conversation == null)
		{
			return Task.FromException<int>(new ObjectDisposedException("KcpStream"));
		}
		return _conversation.ReadAsync(buffer.AsMemory(offset, count), cancellationToken).AsTask();
	}

	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		if (_conversation == null)
		{
			return Task.FromException(new ObjectDisposedException("KcpStream"));
		}
		return _conversation.WriteAsync(buffer.AsMemory(offset, count), cancellationToken).AsTask();
	}

	public override int ReadByte()
	{
		throw new NotSupportedException();
	}

	public override void WriteByte(byte value)
	{
		throw new NotSupportedException();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && _ownsConversation)
		{
			_conversation?.Dispose();
		}
		_conversation = null;
		base.Dispose(disposing);
	}

	public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (_conversation == null)
		{
			return new ValueTask<int>(Task.FromException<int>(new ObjectDisposedException("KcpStream")));
		}
		return _conversation.ReadAsync(buffer, cancellationToken);
	}

	public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (_conversation == null)
		{
			return new ValueTask(Task.FromException(new ObjectDisposedException("KcpStream")));
		}
		return _conversation.WriteAsync(buffer, cancellationToken);
	}

	public override ValueTask DisposeAsync()
	{
		if (_conversation != null)
		{
			_conversation.Dispose();
			_conversation = null;
		}
		return base.DisposeAsync();
	}

	public override int Read(Span<byte> buffer)
	{
		throw new NotSupportedException();
	}

	public override void Write(ReadOnlySpan<byte> buffer)
	{
		throw new NotSupportedException();
	}
}
