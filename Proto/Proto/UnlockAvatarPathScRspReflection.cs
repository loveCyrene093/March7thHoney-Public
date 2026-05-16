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
		buffer[0] = "ChtVbmxvY2tBdmF0YXJQYXRoU2NSc3AucHJvdG8aDkl0ZW1MaXN0LnByb3Rv";
		buffer[1] = "GhlNdWx0aVBhdGhBdmF0YXJUeXBlLnByb3RvIogBChVVbmxvY2tBdmF0YXJQ";
		buffer[2] = "YXRoU2NSc3ASJwoJYXZhdGFyX2lkGAIgASgOMhQuTXVsdGlQYXRoQXZhdGFy";
		buffer[3] = "VHlwZRIaChJiYXNpY190eXBlX2lkX2xpc3QYCCADKA0SGQoGcmV3YXJkGAkg";
		buffer[4] = "ASgLMgkuSXRlbUxpc3QSDwoHcmV0Y29kZRgMIAEoDUIWqgITTWFyY2g3dGhI";
		buffer[5] = "b25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ItemListReflection.Descriptor,
			MultiPathAvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UnlockAvatarPathScRsp), UnlockAvatarPathScRsp.Parser, new string[4] { "AvatarId", "BasicTypeIdList", "Reward", "Retcode" }, null, null, null, null)
		}));
	}
}
