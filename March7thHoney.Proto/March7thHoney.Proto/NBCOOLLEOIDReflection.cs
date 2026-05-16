using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NBCOOLLEOIDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NBCOOLLEOIDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOQkNPT0xMRU9JRC5wcm90bxoOQnVmZkluZm8ucHJvdG8iPgoLTkJDT09M" + "TEVPSUQSEQoJZW50aXR5X2lkGAggASgNEhwKCWJ1ZmZfbGlzdBgOIAMoCzIJ" + "LkJ1ZmZJbmZvQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { BuffInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NBCOOLLEOID), NBCOOLLEOID.Parser, new string[2] { "EntityId", "BuffList" }, null, null, null, null)
		}));
	}
}
