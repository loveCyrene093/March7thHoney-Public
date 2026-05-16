using System.Collections.Generic;
using System.Threading;

namespace March7thHoney.Kcp.KcpSharp;

internal struct KcpSendReceiveBufferItemCache
{
	private LinkedList<KcpSendReceiveBufferItem> _items;

	private SpinLock _lock;

	public static KcpSendReceiveBufferItemCache Create()
	{
		return new KcpSendReceiveBufferItemCache
		{
			_items = new LinkedList<KcpSendReceiveBufferItem>(),
			_lock = default(SpinLock)
		};
	}

	public LinkedListNode<KcpSendReceiveBufferItem> Allocate(in KcpSendReceiveBufferItem item)
	{
		bool lockTaken = false;
		try
		{
			_lock.Enter(ref lockTaken);
			LinkedListNode<KcpSendReceiveBufferItem> linkedListNode = _items.First;
			if (linkedListNode == null)
			{
				linkedListNode = new LinkedListNode<KcpSendReceiveBufferItem>(item);
			}
			else
			{
				_items.Remove(linkedListNode);
				linkedListNode.ValueRef = item;
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

	public void Return(LinkedListNode<KcpSendReceiveBufferItem> node)
	{
		bool lockTaken = false;
		try
		{
			_lock.Enter(ref lockTaken);
			node.ValueRef = default(KcpSendReceiveBufferItem);
			_items.AddLast(node);
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
