using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SelectChatBubbleCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SelectChatBubbleCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtTZWxlY3RDaGF0QnViYmxlQ3NSZXEucHJvdG8iKgoVU2VsZWN0Q2hhdEJ1" + "YmJsZUNzUmVxEhEKCWJ1YmJsZV9pZBgGIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SelectChatBubbleCsReq), SelectChatBubbleCsReq.Parser, new string[1] { "BubbleId" }, null, null, null, null)
		}));
	}
}
