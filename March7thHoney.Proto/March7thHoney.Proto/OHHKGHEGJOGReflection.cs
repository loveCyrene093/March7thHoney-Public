using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OHHKGHEGJOGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OHHKGHEGJOGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPSEhLR0hFR0pPRy5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJCCgtPSEhL" + "R0hFR0pPRxIRCglhdmF0YXJfaWQYASABKA0SIAoLYXZhdGFyX3R5cGUYDiAB" + "KA4yCy5BdmF0YXJUeXBlQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { AvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OHHKGHEGJOG), OHHKGHEGJOG.Parser, new string[2] { "AvatarId", "AvatarType" }, null, null, null, null)
		}));
	}
}
