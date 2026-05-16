using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishEmotionDialoguePerformanceCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishEmotionDialoguePerformanceCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CitGaW5pc2hFbW90aW9uRGlhbG9ndWVQZXJmb3JtYW5jZUNzUmVxLnByb3Rv" + "ImQKJUZpbmlzaEVtb3Rpb25EaWFsb2d1ZVBlcmZvcm1hbmNlQ3NSZXESEwoL" + "ZGlhbG9ndWVfaWQYAyABKA0SEwoLQUlMT01CSU1JQ0IYBCABKA0SEQoJc2Ny" + "aXB0X2lkGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishEmotionDialoguePerformanceCsReq), FinishEmotionDialoguePerformanceCsReq.Parser, new string[3] { "DialogueId", "AILOMBIMICB", "ScriptId" }, null, null, null, null)
		}));
	}
}
