using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetQuestDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetQuestDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdHZXRRdWVzdERhdGFTY1JzcC5wcm90bxoLUXVlc3QucHJvdG8iXwoRR2V0" + "UXVlc3REYXRhU2NSc3ASDwoHcmV0Y29kZRgDIAEoDRIaCgpxdWVzdF9saXN0" + "GAUgAygLMgYuUXVlc3QSHQoVdG90YWxfYWNoaWV2ZW1lbnRfZXhwGA4gASgN" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { QuestReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetQuestDataScRsp), GetQuestDataScRsp.Parser, new string[3] { "Retcode", "QuestList", "TotalAchievementExp" }, null, null, null, null)
		}));
	}
}
