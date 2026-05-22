using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OIIADJCEMKBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OIIADJCEMKBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPSUlBREpDRU1LQi5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJCCgtPSUlB" + "REpDRU1LQhIRCglhdmF0YXJfaWQYASABKA0SIAoLYXZhdGFyX3R5cGUYCSAB" + "KA4yCy5BdmF0YXJUeXBlQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { AvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OIIADJCEMKB), OIIADJCEMKB.Parser, new string[2] { "AvatarId", "AvatarType" }, null, null, null, null)
		}));
	}
}
