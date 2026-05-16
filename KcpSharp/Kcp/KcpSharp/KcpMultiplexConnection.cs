using System;
using System.Buffers.Binary;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace March7thHoney.Kcp.KcpSharp;

public sealed class KcpMultiplexConnection<T> : IKcpTransport, IKcpConversation, IDisposable, IKcpMultiplexConnection<T>, IKcpMultiplexConnection
{
	private readonly ConcurrentDictionary<long, (IKcpConversation Conversation, T? State)> _conversations = new ConcurrentDictionary<long, (IKcpConversation, T)>();

	private readonly Action<T?>? _disposeAction;

	private readonly IKcpTransport _transport;

	private bool _disposed;

	private bool _transportClosed;

	public KcpMultiplexConnection(IKcpTransport transport)
	{
		_transport = transport ?? throw new ArgumentNullException("transport");
		_disposeAction = null;
	}

	public KcpMultiplexConnection(IKcpTransport transport, Action<T?>? disposeAction)
	{
		_transport = transport ?? throw new ArgumentNullException("transport");
		_disposeAction = disposeAction;
	}

	public ValueTask InputPakcetAsync(UdpReceiveResult packet, CancellationToken cancellationToken = default(CancellationToken))
	{
		ReadOnlySpan<byte> source = packet.Buffer.AsSpan();
		if (source.Length < 8)
		{
			return default(ValueTask);
		}
		if (_transportClosed || _disposed)
		{
			return default(ValueTask);
		}
		long key = BinaryPrimitives.ReadInt64BigEndian(source);
		if (_conversations.TryGetValue(key, out (IKcpConversation, T) value))
		{
			return value.Item1.InputPakcetAsync(packet, cancellationToken);
		}
		return default(ValueTask);
	}

	public void SetTransportClosed()
	{
		_transportClosed = true;
		foreach (var value in _conversations.Values)
		{
			value.Conversation.SetTransportClosed();
		}
	}

	public void Dispose()
	{
		if (_disposed)
		{
			return;
		}
		_transportClosed = true;
		_disposed = true;
		while (!_conversations.IsEmpty)
		{
			foreach (long key in _conversations.Keys)
			{
				if (_conversations.TryRemove(key, out (IKcpConversation, T) value))
				{
					value.Item1.Dispose();
					if (_disposeAction != null)
					{
						_disposeAction(value.Item2);
					}
				}
			}
		}
	}

	public bool Contains(long id)
	{
		CheckDispose();
		return _conversations.ContainsKey(id);
	}

	public KcpRawChannel CreateRawChannel(long id, IPEndPoint remoteEndpoint, KcpRawChannelOptions? options = null)
	{
		KcpRawChannel location = new KcpRawChannel(remoteEndpoint, this, id, options);
		try
		{
			RegisterConversation(location, id, default(T));
			if (_transportClosed)
			{
				location.SetTransportClosed();
			}
			return Interlocked.Exchange(ref location, null);
		}
		finally
		{
			location?.Dispose();
		}
	}

	public KcpRawChannel CreateRawChannel(long id, IPEndPoint remoteEndpoint, T state, KcpRawChannelOptions? options = null)
	{
		KcpRawChannel location = new KcpRawChannel(remoteEndpoint, this, id, options);
		try
		{
			RegisterConversation(location, id, state);
			if (_transportClosed)
			{
				location.SetTransportClosed();
			}
			return Interlocked.Exchange(ref location, null);
		}
		finally
		{
			location?.Dispose();
		}
	}

	public KcpConversation CreateConversation(long id, IPEndPoint remoteEndpoint, KcpConversationOptions? options = null)
	{
		KcpConversation location = new KcpConversation(remoteEndpoint, this, id, options);
		try
		{
			RegisterConversation(location, id, default(T));
			if (_transportClosed)
			{
				location.SetTransportClosed();
			}
			return Interlocked.Exchange(ref location, null);
		}
		finally
		{
			location?.Dispose();
		}
	}

	public KcpConversation CreateConversation(long id, IPEndPoint remoteEndpoint, T state, KcpConversationOptions? options = null)
	{
		KcpConversation location = new KcpConversation(remoteEndpoint, this, id, options);
		try
		{
			RegisterConversation(location, id, state);
			if (_transportClosed)
			{
				location.SetTransportClosed();
			}
			return Interlocked.Exchange(ref location, null);
		}
		finally
		{
			location?.Dispose();
		}
	}

	public void RegisterConversation(IKcpConversation conversation, long id)
	{
		RegisterConversation(conversation, id, default(T));
	}

	public void RegisterConversation(IKcpConversation conversation, long id, T? state)
	{
		if (conversation == null)
		{
			throw new ArgumentNullException("conversation");
		}
		CheckDispose();
		if (_conversations.GetOrAdd(id, (conversation, state)).Conversation != conversation)
		{
			throw new InvalidOperationException("Duplicated conversation.");
		}
		if (_disposed)
		{
			if (_conversations.TryRemove(id, out (IKcpConversation, T) value) && _disposeAction != null)
			{
				_disposeAction(value.Item2);
			}
			ThrowObjectDisposedException();
		}
	}

	public IKcpConversation? UnregisterConversation(long id)
	{
		T state;
		return UnregisterConversation(id, out state);
	}

	public IKcpConversation? UnregisterConversation(long id, out T? state)
	{
		if (!_transportClosed && !_disposed && _conversations.TryRemove(id, out (IKcpConversation, T) value))
		{
			value.Item1.SetTransportClosed();
			state = value.Item2;
			if (_disposeAction != null)
			{
				_disposeAction(state);
			}
			return value.Item1;
		}
		state = default(T);
		return null;
	}

	public ValueTask SendPacketAsync(Memory<byte> packet, IPEndPoint remoteEndpoint, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (_transportClosed || _disposed)
		{
			return default(ValueTask);
		}
		return _transport.SendPacketAsync(packet, remoteEndpoint, cancellationToken);
	}

	private void CheckDispose()
	{
		if (_disposed)
		{
			ThrowObjectDisposedException();
		}
	}

	private static void ThrowObjectDisposedException()
	{
		throw new ObjectDisposedException("KcpMultiplexConnection");
	}
}
