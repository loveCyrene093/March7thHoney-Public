using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFriendRecommendLineupDetailScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFriendRecommendLineupDetailScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "CilHZXRGcmllbmRSZWNvbW1lbmRMaW5ldXBEZXRhaWxTY1JzcC5wcm90bxod";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "RGlzcGxheUF2YXRhckRldGFpbEluZm8ucHJvdG8aEU5GS0VKSklIT0NKLnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "b3RvIpsBCiNHZXRGcmllbmRSZWNvbW1lbmRMaW5ldXBEZXRhaWxTY1JzcBIL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "CgNrZXkYBSABKA0SLQoLTUVPRk5HQ0ZBQkoYByADKAsyGC5EaXNwbGF5QXZh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "dGFyRGV0YWlsSW5mbxIPCgdyZXRjb2RlGAogASgNEhoKBHR5cGUYCyABKA4y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "DC5ORktFSkpJSE9DShILCgN1aWQYDyABKA1CFqoCE01hcmNoN3RoSG9uZXku";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[2]
		{
			DisplayAvatarDetailInfoReflection.Descriptor,
			NFKEJJIHOCJReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendRecommendLineupDetailScRsp), GetFriendRecommendLineupDetailScRsp.Parser, new string[5] { "Key", "MEOFNGCFABJ", "Retcode", "Type", "Uid" }, null, null, null, null)
		}));
	}
}
