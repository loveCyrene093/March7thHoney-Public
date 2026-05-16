using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DJCHCHCAJPBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DJCHCHCAJPBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFESkNIQ0hDQUpQQi5wcm90byIeCgtESkNIQ0hDQUpQQhIPCgdyZXRjb2Rl" + "GA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DJCHCHCAJPB), DJCHCHCAJPB.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
