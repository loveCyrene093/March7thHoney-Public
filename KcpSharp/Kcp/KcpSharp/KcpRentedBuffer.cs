using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace March7thHoney.Kcp.KcpSharp;

public readonly struct KcpRentedBuffer : IEquatable<KcpRentedBuffer>, IDisposable
{
	private readonly Memory<byte> _memory;

	internal object? Owner { get; }

	public Memory<byte> Memory => _memory;

	public Span<byte> Span => _memory.Span;

	public bool IsAllocated => Owner != null;

	public bool IsEmpry => _memory.IsEmpty;

	internal KcpRentedBuffer(object? owner, Memory<byte> buffer)
	{
		Owner = owner;
		_memory = buffer;
	}

	public static KcpRentedBuffer FromMemory(Memory<byte> memory)
	{
		return new KcpRentedBuffer(null, memory);
	}

	public static KcpRentedBuffer FromSharedArrayPool(int size)
	{
		if (size < 0)
		{
			throw new ArgumentOutOfRangeException("size");
		}
		byte[] array = ArrayPool<byte>.Shared.Rent(size);
		return new KcpRentedBuffer(ArrayPool<byte>.Shared, array);
	}

	public static KcpRentedBuffer FromArrayPool(ArrayPool<byte> pool, byte[] buffer)
	{
		if (pool == null)
		{
			throw new ArgumentNullException("pool");
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		return new KcpRentedBuffer(pool, buffer);
	}

	public static KcpRentedBuffer FromArrayPool(ArrayPool<byte> pool, ArraySegment<byte> arraySegment)
	{
		if (pool == null)
		{
			throw new ArgumentNullException("pool");
		}
		return new KcpRentedBuffer(pool, arraySegment);
	}

	public static KcpRentedBuffer FromArrayPool(ArrayPool<byte> pool, int size)
	{
		if (pool == null)
		{
			throw new ArgumentNullException("pool");
		}
		if (size < 0)
		{
			throw new ArgumentOutOfRangeException("size");
		}
		return new KcpRentedBuffer(pool, pool.Rent(size));
	}

	public static KcpRentedBuffer FromMemoryOwner(IMemoryOwner<byte> memoryOwner)
	{
		if (memoryOwner == null)
		{
			throw new ArgumentNullException("memoryOwner");
		}
		return new KcpRentedBuffer(memoryOwner, memoryOwner.Memory);
	}

	public static KcpRentedBuffer FromMemoryOwner(IDisposable memoryOwner, Memory<byte> memory)
	{
		if (memoryOwner == null)
		{
			throw new ArgumentNullException("memoryOwner");
		}
		return new KcpRentedBuffer(memoryOwner, memory);
	}

	public KcpRentedBuffer Slice(int start)
	{
		Memory<byte> memory = _memory;
		if ((uint)start > (uint)memory.Length)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException("start");
		}
		return new KcpRentedBuffer(Owner, memory.Slice(start));
	}

	public KcpRentedBuffer Slice(int start, int length)
	{
		Memory<byte> memory = _memory;
		if ((uint)start > (uint)memory.Length)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException("start");
		}
		if ((uint)length > (uint)(memory.Length - start))
		{
			ThrowHelper.ThrowArgumentOutOfRangeException("length");
		}
		return new KcpRentedBuffer(Owner, memory.Slice(start, length));
	}

	public void Dispose()
	{
		if (Owner != null)
		{
			if (Owner is ArrayPool<byte> arrayPool && MemoryMarshal.TryGetArray((ReadOnlyMemory<byte>)_memory, out ArraySegment<byte> segment))
			{
				arrayPool.Return(segment.Array);
			}
			else if (Owner is IDisposable disposable)
			{
				disposable.Dispose();
			}
		}
	}

	public bool Equals(KcpRentedBuffer other)
	{
		if (Owner == other.Owner)
		{
			return _memory.Equals(other._memory);
		}
		return false;
	}

	public override bool Equals(object? obj)
	{
		if (obj is KcpRentedBuffer other)
		{
			return Equals(other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		if (Owner != null)
		{
			return HashCode.Combine(RuntimeHelpers.GetHashCode(Owner), _memory);
		}
		return _memory.GetHashCode();
	}

	public override string ToString()
	{
		return $"KcpSharp.KcpRentedBuffer[{_memory.Length}]";
	}
}
