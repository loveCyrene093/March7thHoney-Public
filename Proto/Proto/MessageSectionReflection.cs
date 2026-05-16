using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MessageSectionReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MessageSectionReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChRNZXNzYWdlU2VjdGlvbi5wcm90bxoRTWVzc2FnZUl0ZW0ucHJvdG8aGk1l";
		buffer[1] = "c3NhZ2VTZWN0aW9uU3RhdHVzLnByb3RvIpcBCg5NZXNzYWdlU2VjdGlvbhIl";
		buffer[2] = "CgZzdGF0dXMYAiABKA4yFS5NZXNzYWdlU2VjdGlvblN0YXR1cxIZChFtZXNz";
		buffer[3] = "YWdlX2l0ZW1fbGlzdBgDIAMoDRIWCg5mcm96ZW5faXRlbV9pZBgHIAEoDRIf";
		buffer[4] = "CglpdGVtX2xpc3QYDCADKAsyDC5NZXNzYWdlSXRlbRIKCgJpZBgNIAEoDUIW";
		buffer[5] = "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			MessageItemReflection.Descriptor,
			MessageSectionStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MessageSection), MessageSection.Parser, new string[5] { "Status", "MessageItemList", "FrozenItemId", "ItemList", "Id" }, null, null, null, null)
		}));
	}
}
