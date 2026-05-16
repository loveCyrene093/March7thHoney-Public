using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightTraitActionInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightTraitActionInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5HcmlkRmlnaHRUcmFpdEFjdGlvbkluZm8ucHJvdG8ibwoYR3JpZEZpZ2h0" + "VHJhaXRBY3Rpb25JbmZvEi4KJmdyaWRfZmlnaHRfdHJhaXRfbWVtYmVyX3Vu" + "aXF1ZV9pZF9saXN0GAwgAygNEhAKCHRyYWl0X2lkGA4gASgNEhEKCWVmZmVj" + "dF9pZBgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightTraitActionInfo), GridFightTraitActionInfo.Parser, new string[3] { "GridFightTraitMemberUniqueIdList", "TraitId", "EffectId" }, null, null, null, null)
		}));
	}
}
