using System;

namespace March7thHoney.Kcp.KcpSharp;

public interface IKcpExceptionProducer<out T>
{
	void SetExceptionHandler(Func<Exception, T, object?, bool> handler, object? state);
}
