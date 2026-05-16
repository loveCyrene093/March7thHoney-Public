using System;
using System.Net;

namespace March7thHoney.Kcp.KcpSharp;

public interface IKcpMultiplexConnection : IDisposable
{
	bool Contains(long id);

	KcpRawChannel CreateRawChannel(long id, IPEndPoint remoteEndpoint, KcpRawChannelOptions? options = null);

	KcpConversation CreateConversation(long id, IPEndPoint remoteEndpoint, KcpConversationOptions? options = null);

	void RegisterConversation(IKcpConversation conversation, long id);

	IKcpConversation? UnregisterConversation(long id);
}
public interface IKcpMultiplexConnection<T> : IKcpMultiplexConnection, IDisposable
{
	KcpRawChannel CreateRawChannel(long id, IPEndPoint remoteEndpoint, T state, KcpRawChannelOptions? options = null);

	KcpConversation CreateConversation(long id, IPEndPoint remoteEndpoint, T state, KcpConversationOptions? options = null);

	void RegisterConversation(IKcpConversation conversation, long id, T? state);

	IKcpConversation? UnregisterConversation(long id, out T? state);
}
