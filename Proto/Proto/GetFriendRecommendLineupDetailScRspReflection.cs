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
		buffer[0] = "CilHZXRGcmllbmRSZWNvbW1lbmRMaW5ldXBEZXRhaWxTY1JzcC5wcm90bxod";
		buffer[1] = "RGlzcGxheUF2YXRhckRldGFpbEluZm8ucHJvdG8aEU5GS0VKSklIT0NKLnBy";
		buffer[2] = "b3RvIpsBCiNHZXRGcmllbmRSZWNvbW1lbmRMaW5ldXBEZXRhaWxTY1JzcBIL";
		buffer[3] = "CgNrZXkYBSABKA0SLQoLTUVPRk5HQ0ZBQkoYByADKAsyGC5EaXNwbGF5QXZh";
		buffer[4] = "dGFyRGV0YWlsSW5mbxIPCgdyZXRjb2RlGAogASgNEhoKBHR5cGUYCyABKA4y";
		buffer[5] = "DC5ORktFSkpJSE9DShILCgN1aWQYDyABKA1CFqoCE01hcmNoN3RoSG9uZXku";
		buffer[6] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			DisplayAvatarDetailInfoReflection.Descriptor,
			NFKEJJIHOCJReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendRecommendLineupDetailScRsp), GetFriendRecommendLineupDetailScRsp.Parser, new string[5] { "Key", "MEOFNGCFABJ", "Retcode", "Type", "Uid" }, null, null, null, null)
		}));
	}
}
