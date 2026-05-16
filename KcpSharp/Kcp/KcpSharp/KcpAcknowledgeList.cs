using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace March7thHoney.Kcp.KcpSharp;

internal sealed class KcpAcknowledgeList
{
	private readonly KcpSendQueue _sendQueue;

	private (uint SerialNumber, uint Timestamp)[] _array;

	private int _count;

	private SpinLock _lock;

	public KcpAcknowledgeList(KcpSendQueue sendQueue, int windowSize)
	{
		_array = new(uint, uint)[windowSize];
		_count = 0;
		_lock = default(SpinLock);
		_sendQueue = sendQueue;
	}

	public bool TryGetAt(int index, out uint serialNumber, out uint timestamp)
	{
		bool lockTaken = false;
		try
		{
			_lock.Enter(ref lockTaken);
			if ((uint)index >= (uint)_count)
			{
				serialNumber = 0u;
				timestamp = 0u;
				return false;
			}
			(serialNumber, timestamp) = _array[index];
			return true;
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
			_count = 0;
		}
		finally
		{
			if (lockTaken)
			{
				_lock.Exit();
			}
		}
		_sendQueue.NotifyAckListChanged(itemsListNotEmpty: false);
	}

	public void Add(uint serialNumber, uint timestamp)
	{
		bool lockTaken = false;
		try
		{
			_lock.Enter(ref lockTaken);
			EnsureCapacity();
			_array[_count++] = (SerialNumber: serialNumber, Timestamp: timestamp);
		}
		finally
		{
			if (lockTaken)
			{
				_lock.Exit();
			}
		}
		_sendQueue.NotifyAckListChanged(itemsListNotEmpty: true);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void EnsureCapacity()
	{
		if (_count == _array.Length)
		{
			Expand();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Expand()
	{
		int num = _count + 1;
		(uint, uint)[] array = new(uint, uint)[Math.Max(num + num / 2, 16)];
		_array.AsSpan(0, _count).CopyTo(array);
		_array = array;
	}
}
