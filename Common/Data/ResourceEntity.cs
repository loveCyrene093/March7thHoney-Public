using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace March7thHoney.Data;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class ResourceEntity : Attribute
{
	public List<string> FileName { get; private set; }

	[Obsolete("No effect")]
	public bool IsCritical { get; private set; }

	[Obsolete("No effect")]
	public ResourceEntity(string fileName, bool isCritical = false, bool isMultifile = false)
	{
		if (isMultifile)
		{
			FileName = new List<string>(fileName.Split(','));
		}
		else
		{
			int num = 1;
			List<string> list = new List<string>(num);
			CollectionsMarshal.SetCount(list, num);
			CollectionsMarshal.AsSpan(list)[0] = fileName;
			FileName = list;
		}
		IsCritical = isCritical;
	}

	public ResourceEntity(string fileName, bool isMultifile = false)
	{
		if (isMultifile)
		{
			FileName = new List<string>(fileName.Split(','));
			return;
		}
		int num = 1;
		List<string> list = new List<string>(num);
		CollectionsMarshal.SetCount(list, num);
		CollectionsMarshal.AsSpan(list)[0] = fileName;
		FileName = list;
	}

	public ResourceEntity(string fileName)
	{
		int num = 1;
		List<string> list = new List<string>(num);
		CollectionsMarshal.SetCount(list, num);
		CollectionsMarshal.AsSpan(list)[0] = fileName;
		FileName = list;
	}
}
