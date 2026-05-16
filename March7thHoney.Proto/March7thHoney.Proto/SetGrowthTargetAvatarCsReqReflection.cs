using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetGrowthTargetAvatarCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetGrowthTargetAvatarCsReqReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "CiBTZXRHcm93dGhUYXJnZXRBdmF0YXJDc1JlcS5wcm90bxoXR3Jvd3RoVGFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "Z2V0U3RhdGUucHJvdG8aG0dyb3d0aFRhcnRnZXRGdW5jVHlwZS5wcm90byKV";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "AQoaU2V0R3Jvd3RoVGFyZ2V0QXZhdGFyQ3NSZXESEwoLS05DSlBKRk1QQUoY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "ASABKA0SKwoLREhBSUpMSkNKQUYYBCADKA4yFi5Hcm93dGhUYXJ0Z2V0RnVu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "Y1R5cGUSEQoJYXZhdGFyX2lkGAkgASgNEiIKBnNvdXJjZRgOIAEoDjISLkdy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "b3d0aFRhcmdldFN0YXRlQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[2]
		{
			GrowthTargetStateReflection.Descriptor,
			GrowthTartgetFuncTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetGrowthTargetAvatarCsReq), SetGrowthTargetAvatarCsReq.Parser, new string[4] { "KNCJPJFMPAJ", "DHAIJLJCJAF", "AvatarId", "Source" }, null, null, null, null)
		}));
	}
}
