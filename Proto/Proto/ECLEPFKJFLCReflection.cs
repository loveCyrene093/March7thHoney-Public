using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ECLEPFKJFLCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ECLEPFKJFLCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFQ0xFUEZLSkZMQy5wcm90byI4CgtFQ0xFUEZLSkZMQxIWCg5hdmF0YXJf" + "aWRfbGlzdBgBIAMoDRIRCglzdG9wX2Rlc2MYAiABKAlCFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ECLEPFKJFLC), ECLEPFKJFLC.Parser, new string[2] { "AvatarIdList", "StopDesc" }, null, null, null, null)
		}));
	}
}
