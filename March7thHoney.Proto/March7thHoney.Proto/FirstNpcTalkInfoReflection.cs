using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FirstNpcTalkInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FirstNpcTalkInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZGaXJzdE5wY1RhbGtJbmZvLnByb3RvIjMKEEZpcnN0TnBjVGFsa0luZm8S" + "DgoGbnBjX2lkGAwgASgNEg8KB2lzX21lZXQYDSABKAhCFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FirstNpcTalkInfo), FirstNpcTalkInfo.Parser, new string[2] { "NpcId", "IsMeet" }, null, null, null, null)
		}));
	}
}
