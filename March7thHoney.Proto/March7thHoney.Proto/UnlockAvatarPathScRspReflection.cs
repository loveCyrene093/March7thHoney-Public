using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UnlockAvatarPathScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UnlockAvatarPathScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChtVbmxvY2tBdmF0YXJQYXRoU2NSc3AucHJvdG8aDkl0ZW1MaXN0LnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "GhlNdWx0aVBhdGhBdmF0YXJUeXBlLnByb3RvIogBChVVbmxvY2tBdmF0YXJQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "YXRoU2NSc3ASJwoJYXZhdGFyX2lkGAIgASgOMhQuTXVsdGlQYXRoQXZhdGFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "VHlwZRIaChJiYXNpY190eXBlX2lkX2xpc3QYCCADKA0SGQoGcmV3YXJkGAkg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "ASgLMgkuSXRlbUxpc3QSDwoHcmV0Y29kZRgMIAEoDUIWqgITTWFyY2g3dGhI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "b25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			ItemListReflection.Descriptor,
			MultiPathAvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UnlockAvatarPathScRsp), UnlockAvatarPathScRsp.Parser, new string[4] { "AvatarId", "BasicTypeIdList", "Reward", "Retcode" }, null, null, null, null)
		}));
	}
}
