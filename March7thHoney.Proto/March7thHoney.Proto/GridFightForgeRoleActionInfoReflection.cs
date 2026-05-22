using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightForgeRoleActionInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightForgeRoleActionInfoReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiJHcmlkRmlnaHRGb3JnZVJvbGVBY3Rpb25JbmZvLnByb3RvGhxHcmlkRmln";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "aHRGb3JnZVJvbGVJbmZvLnByb3RvImgKHEdyaWRGaWdodEZvcmdlUm9sZUFj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "dGlvbkluZm8SMQoQZm9yZ2VfZ29vZHNfbGlzdBgBIAMoCzIXLkdyaWRGaWdo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "dEZvcmdlUm9sZUluZm8SFQoNZm9yZ2VfaXRlbV9pZBgJIAEoDUIWqgITTWFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { GridFightForgeRoleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightForgeRoleActionInfo), GridFightForgeRoleActionInfo.Parser, new string[2] { "ForgeGoodsList", "ForgeItemId" }, null, null, null, null)
		}));
	}
}
