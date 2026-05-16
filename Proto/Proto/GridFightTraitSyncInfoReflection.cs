using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightTraitSyncInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightTraitSyncInfoReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChxHcmlkRmlnaHRUcmFpdFN5bmNJbmZvLnByb3RvGh5HcmlkRmlnaHRUcmFp";
		buffer[1] = "dEVmZmVjdEluZm8ucHJvdG8ieAoWR3JpZEZpZ2h0VHJhaXRTeW5jSW5mbxI0";
		buffer[2] = "ChF0cmFpdF9lZmZlY3RfaW5mbxgMIAEoCzIZLkdyaWRGaWdodFRyYWl0RWZm";
		buffer[3] = "ZWN0SW5mbxIQCgh0cmFpdF9pZBgNIAEoDRIWCg5pc19zeW5jX2VmZmVjdBgP";
		buffer[4] = "IAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GridFightTraitEffectInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightTraitSyncInfo), GridFightTraitSyncInfo.Parser, new string[3] { "TraitEffectInfo", "TraitId", "IsSyncEffect" }, null, null, null, null)
		}));
	}
}
