using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TelevisionActivityBattleEndScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TelevisionActivityBattleEndScNotifyReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CilUZWxldmlzaW9uQWN0aXZpdHlCYXR0bGVFbmRTY05vdGlmeS5wcm90bxoR";
		buffer[1] = "Q0tGSE9MS0pBR0MucHJvdG8imgEKI1RlbGV2aXNpb25BY3Rpdml0eUJhdHRs";
		buffer[2] = "ZUVuZFNjTm90aWZ5EiEKC0tBRURFRU1PQ0RBGAQgASgLMgwuQ0tGSE9MS0pB";
		buffer[3] = "R0MSEwoLRVBMQkNORk1MSUwYByABKA0SEwoLTkVDQUJMQktIS04YCCABKA0S";
		buffer[4] = "EQoJdHVybl9sZWZ0GAogASgNEhMKC09MR0hQT09ERU5LGA0gASgNQhaqAhNN";
		buffer[5] = "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { CKFHOLKJAGCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TelevisionActivityBattleEndScNotify), TelevisionActivityBattleEndScNotify.Parser, new string[5] { "KAEDEEMOCDA", "EPLBCNFMLIL", "NECABLBKHKN", "TurnLeft", "OLGHPOODENK" }, null, null, null, null)
		}));
	}
}
