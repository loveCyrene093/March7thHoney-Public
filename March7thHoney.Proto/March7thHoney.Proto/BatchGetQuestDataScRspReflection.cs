using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BatchGetQuestDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BatchGetQuestDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxCYXRjaEdldFF1ZXN0RGF0YVNjUnNwLnByb3RvGgtRdWVzdC5wcm90byJF" + "ChZCYXRjaEdldFF1ZXN0RGF0YVNjUnNwEhoKCnF1ZXN0X2xpc3QYByADKAsy" + "Bi5RdWVzdBIPCgdyZXRjb2RlGAwgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[1] { QuestReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BatchGetQuestDataScRsp), BatchGetQuestDataScRsp.Parser, new string[2] { "QuestList", "Retcode" }, null, null, null, null)
		}));
	}
}
