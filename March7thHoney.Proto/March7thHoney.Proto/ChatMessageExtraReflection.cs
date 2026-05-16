using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChatMessageExtraReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChatMessageExtraReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZDaGF0TWVzc2FnZUV4dHJhLnByb3RvIi8KEENoYXRNZXNzYWdlRXh0cmES" + "DAoEa2luZBgBIAEoDRINCgV2YWx1ZRgCIAEoBEIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChatMessageExtra), ChatMessageExtra.Parser, new string[2] { "Kind", "Value" }, null, null, null, null)
		}));
	}
}
