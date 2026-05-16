using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BlackInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BlackInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg9CbGFja0luZm8ucHJvdG8iWAoJQmxhY2tJbmZvEhIKCmJlZ2luX3RpbWUY" + "ASABKAMSEAoIZW5kX3RpbWUYAiABKAMSEwoLbGltaXRfbGV2ZWwYAyABKA0S" + "EAoIYmFuX3R5cGUYBCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BlackInfo), BlackInfo.Parser, new string[4] { "BeginTime", "EndTime", "LimitLevel", "BanType" }, null, null, null, null)
		}));
	}
}
