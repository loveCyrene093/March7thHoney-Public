using System;
using System.Collections.Generic;
using System.Linq;

namespace March7thHoney.Util;

public class RandomList<T>
{
	private readonly List<T> _list = new List<T>();

	public RandomList()
	{
	}

	public RandomList(IEnumerable<T> collection)
	{
		_list.AddRange(collection);
	}

	public void Add(T item, int weight)
	{
		for (int i = 0; i < weight; i++)
		{
			_list.Add(item);
		}
	}

	public void Remove(T item)
	{
		List<T> list = _list.Clone().ToList();
		_list.Clear();
		foreach (T item2 in list)
		{
			T current = item2;
			ref T reference = ref current;
			T val = default(T);
			if (val == null)
			{
				val = reference;
				reference = ref val;
				if (val == null)
				{
					continue;
				}
			}
			if (!reference.Equals(item))
			{
				_list.Add(current);
			}
		}
	}

	public void AddRange(IEnumerable<T> collection, IEnumerable<int> weights)
	{
		List<T> list = collection.ToList();
		for (int i = 0; i < list.Count; i++)
		{
			Add(list[i], weights.ElementAt(i));
		}
	}

	public T? GetRandom()
	{
		if (_list.Count == 0)
		{
			return default(T);
		}
		return _list[Random.Shared.Next(_list.Count)];
	}

	public void Clear()
	{
		_list.Clear();
	}

	public int GetCount()
	{
		return _list.Count;
	}
}
