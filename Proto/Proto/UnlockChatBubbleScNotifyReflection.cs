using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UnlockChatBubbleScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UnlockChatBubbleScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5VbmxvY2tDaGF0QnViYmxlU2NOb3RpZnkucHJvdG8iLQoYVW5sb2NrQ2hh" + "dEJ1YmJsZVNjTm90aWZ5EhEKCWJ1YmJsZV9pZBgGIAEoDUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UnlockChatBubbleScNotify), UnlockChatBubbleScNotify.Parser, new string[1] { "BubbleId" }, null, null, null, null)
		}));
	}
}
