using System.Collections.Generic;
using System.Threading;

namespace March7thHoney.Kcp.KcpSharp;

internal sealed class KcpSendReceiveQueueItemCache
{
	private readonly LinkedList<(KcpBuffer Data, byte Fragment)> _list = new LinkedList<(KcpBuffer, byte)>();

	private SpinLock _lock;

	public LinkedListNode<(KcpBuffer Data, byte Fragment)> Rent(in KcpBuffer buffer, byte fragment)
	{
		bool lockTaken = false;
		try
		{
			_lock.Enter(ref lockTaken);
			LinkedListNode<(KcpBuffer, byte)> linkedListNode = _list.First;
			if (linkedListNode == null)
			{
				linkedListNode = new LinkedListNode<(KcpBuffer, byte)>((buffer, fragment));
			}
			else
			{
				linkedListNode.ValueRef = (buffer, fragment);
				_list.RemoveFirst();
			}
			return linkedListNode;
		}
		finally
		{
			if (lockTaken)
			{
				_lock.Exit();
			}
		}
	}

	public void Return(LinkedListNode<(KcpBuffer Data, byte Fragment)> node)
	{
		node.ValueRef = default((KcpBuffer, byte));
		bool lockTaken = false;
		try
		{
			_lock.Enter(ref lockTaken);
			_list.AddLast(node);
		}
		finally
		{
			if (lockTaken)
			{
				_lock.Exit();
			}
		}
	}

	public void Clear()
	{
		bool lockTaken = false;
		try
		{
			_lock.Enter(ref lockTaken);
			_list.Clear();
		}
		finally
		{
			if (lockTaken)
			{
				_lock.Exit();
			}
		}
	}
}
