using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFriendRecommendLineupDetailCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFriendRecommendLineupDetailCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CilHZXRGcmllbmRSZWNvbW1lbmRMaW5ldXBEZXRhaWxDc1JlcS5wcm90bxoR";
		buffer[1] = "TkZLRUpKSUhPQ0oucHJvdG8iWwojR2V0RnJpZW5kUmVjb21tZW5kTGluZXVw";
		buffer[2] = "RGV0YWlsQ3NSZXESGgoEdHlwZRgHIAEoDjIMLk5GS0VKSklIT0NKEgsKA2tl";
		buffer[3] = "eRgJIAEoDRILCgN1aWQYCyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		buffer[4] = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { NFKEJJIHOCJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendRecommendLineupDetailCsReq), GetFriendRecommendLineupDetailCsReq.Parser, new string[3] { "Type", "Key", "Uid" }, null, null, null, null)
		}));
	}
}
