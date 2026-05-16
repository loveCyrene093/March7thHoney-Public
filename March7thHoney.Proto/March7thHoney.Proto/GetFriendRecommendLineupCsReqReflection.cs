using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFriendRecommendLineupCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFriendRecommendLineupCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNHZXRGcmllbmRSZWNvbW1lbmRMaW5ldXBDc1JlcS5wcm90bxoRTkZLRUpK" + "SUhPQ0oucHJvdG8iSAodR2V0RnJpZW5kUmVjb21tZW5kTGluZXVwQ3NSZXES" + "GgoEdHlwZRgCIAEoDjIMLk5GS0VKSklIT0NKEgsKA2tleRgKIAEoDUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { NFKEJJIHOCJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendRecommendLineupCsReq), GetFriendRecommendLineupCsReq.Parser, new string[2] { "Type", "Key" }, null, null, null, null)
		}));
	}
}
