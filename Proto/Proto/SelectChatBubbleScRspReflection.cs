using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SelectChatBubbleScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SelectChatBubbleScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtTZWxlY3RDaGF0QnViYmxlU2NSc3AucHJvdG8iVgoVU2VsZWN0Q2hhdEJ1" + "YmJsZVNjUnNwEhMKC0RLSkFHRktQRk9OGAMgASgNEg8KB3JldGNvZGUYDiAB" + "KA0SFwoPY3VyX2NoYXRfYnViYmxlGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SelectChatBubbleScRsp), SelectChatBubbleScRsp.Parser, new string[3] { "DKJAGFKPFON", "Retcode", "CurChatBubble" }, null, null, null, null)
		}));
	}
}
