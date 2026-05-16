using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MessageItemReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MessageItemReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNZXNzYWdlSXRlbS5wcm90byIvCgtNZXNzYWdlSXRlbRIPCgdpdGVtX2lk" + "GAcgASgNEg8KB3RleHRfaWQYCCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MessageItem), MessageItem.Parser, new string[2] { "ItemId", "TextId" }, null, null, null, null)
		}));
	}
}
