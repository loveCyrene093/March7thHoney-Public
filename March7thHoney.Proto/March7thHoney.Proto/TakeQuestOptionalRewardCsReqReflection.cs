using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeQuestOptionalRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeQuestOptionalRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJUYWtlUXVlc3RPcHRpb25hbFJld2FyZENzUmVxLnByb3RvIkwKHFRha2VR" + "dWVzdE9wdGlvbmFsUmV3YXJkQ3NSZXESEAoIcXVlc3RfaWQYASABKA0SGgoS" + "b3B0aW9uYWxfcmV3YXJkX2lkGAYgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeQuestOptionalRewardCsReq), TakeQuestOptionalRewardCsReq.Parser, new string[2] { "QuestId", "OptionalRewardId" }, null, null, null, null)
		}));
	}
}
