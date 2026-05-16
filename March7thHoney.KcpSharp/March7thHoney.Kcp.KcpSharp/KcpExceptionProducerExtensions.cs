using System;

namespace March7thHoney.Kcp.KcpSharp;

public static class KcpExceptionProducerExtensions
{
	public static void SetExceptionHandler<T>(this IKcpExceptionProducer<T> producer, Func<Exception, T, bool> handler)
	{
		if (producer == null)
		{
			throw new ArgumentNullException("producer");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		producer.SetExceptionHandler((Exception ex, T conv, object? state) => ((Func<Exception, T, bool>)state)(ex, conv), handler);
	}

	public static void SetExceptionHandler<T>(this IKcpExceptionProducer<T> producer, Func<Exception, bool> handler)
	{
		if (producer == null)
		{
			throw new ArgumentNullException("producer");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		producer.SetExceptionHandler((Exception ex, T conv, object? state) => ((Func<Exception, bool>)state)(ex), handler);
	}

	public static void SetExceptionHandler<T>(this IKcpExceptionProducer<T> producer, Action<Exception, T, object?> handler, object? state)
	{
		if (producer == null)
		{
			throw new ArgumentNullException("producer");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		producer.SetExceptionHandler(delegate(Exception ex, T conv, object? obj)
		{
			Tuple<Action<Exception, T, object>, object> tuple = (Tuple<Action<Exception, T, object>, object>)obj;
			tuple.Item1(ex, conv, tuple.Item2);
			return false;
		}, Tuple.Create(handler, state));
	}

	public static void SetExceptionHandler<T>(this IKcpExceptionProducer<T> producer, Action<Exception, T> handler)
	{
		if (producer == null)
		{
			throw new ArgumentNullException("producer");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		producer.SetExceptionHandler(delegate(Exception ex, T conv, object? state)
		{
			((Action<Exception, T>)state)(ex, conv);
			return false;
		}, handler);
	}

	public static void SetExceptionHandler<T>(this IKcpExceptionProducer<T> producer, Action<Exception> handler)
	{
		if (producer == null)
		{
			throw new ArgumentNullException("producer");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		producer.SetExceptionHandler(delegate(Exception ex, T conv, object? state)
		{
			((Action<Exception>)state)(ex);
			return false;
		}, handler);
	}
}
