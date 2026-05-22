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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChdHcmlkR2FtZVRyYWl0SW5mby5wcm90bxoeR3JpZEZpZ2h0VHJhaXRFZmZl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "Y3RJbmZvLnByb3RvIsoBChFHcmlkR2FtZVRyYWl0SW5mbxITCgtLSU5JS0ZD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "S0dERhgBIAEoDRI0ChF0cmFpdF9lZmZlY3RfbGlzdBgEIAMoCzIZLkdyaWRG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "aWdodFRyYWl0RWZmZWN0SW5mbxITCgtERk5DRk9LUE1DShgGIAEoDRITCgtO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "S0ZEQkVIUE5MRxgMIAEoDRIQCgh0cmFpdF9pZBgNIAEoDRIuCiZncmlkX2Zp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "Z2h0X3RyYWl0X21lbWJlcl91bmlxdWVfaWRfbGlzdBgOIAMoDUIWqgITTWFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[1] { GridFightTraitEffectInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridGameTraitInfo), GridGameTraitInfo.Parser, new string[6] { "KINIKFCKGDF", "TraitEffectList", "DFNCFOKPMCJ", "NKFDBEHPNLG", "TraitId", "GridFightTraitMemberUniqueIdList" }, null, null, null, null)
		}));
	}
}
