using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridGameTraitInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridGameTraitInfoReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChdHcmlkR2FtZVRyYWl0SW5mby5wcm90bxoeR3JpZEZpZ2h0VHJhaXRFZmZl";
		buffer[1] = "Y3RJbmZvLnByb3RvIsoBChFHcmlkR2FtZVRyYWl0SW5mbxITCgtLSU5JS0ZD";
		buffer[2] = "S0dERhgBIAEoDRI0ChF0cmFpdF9lZmZlY3RfbGlzdBgEIAMoCzIZLkdyaWRG";
		buffer[3] = "aWdodFRyYWl0RWZmZWN0SW5mbxITCgtERk5DRk9LUE1DShgGIAEoDRITCgtO";
		buffer[4] = "S0ZEQkVIUE5MRxgMIAEoDRIQCgh0cmFpdF9pZBgNIAEoDRIuCiZncmlkX2Zp";
		buffer[5] = "Z2h0X3RyYWl0X21lbWJlcl91bmlxdWVfaWRfbGlzdBgOIAMoDUIWqgITTWFy";
		buffer[6] = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GridFightTraitEffectInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridGameTraitInfo), GridGameTraitInfo.Parser, new string[6] { "KINIKFCKGDF", "TraitEffectList", "DFNCFOKPMCJ", "NKFDBEHPNLG", "TraitId", "GridFightTraitMemberUniqueIdList" }, null, null, null, null)
		}));
	}
}
