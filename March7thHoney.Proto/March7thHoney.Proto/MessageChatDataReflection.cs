using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MessageChatDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MessageChatDataReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVNZXNzYWdlQ2hhdERhdGEucHJvdG8aDkNoYXREYXRhLnByb3RvGg1Nc2dU" + "eXBlLnByb3RvIk8KD01lc3NhZ2VDaGF0RGF0YRIeCgxtZXNzYWdlX3R5cGUY" + "ASABKA4yCC5Nc2dUeXBlEhwKCWNoYXRfZGF0YRgCIAEoCzIJLkNoYXREYXRh" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[2]
		{
			ChatDataReflection.Descriptor,
			MsgTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MessageChatData), MessageChatData.Parser, new string[2] { "MessageType", "ChatData" }, null, null, null, null)
		}));
	}
}
