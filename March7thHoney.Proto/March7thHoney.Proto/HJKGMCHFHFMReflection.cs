using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HJKGMCHFHFMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HJKGMCHFHFMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFISktHTUNIRkhGTS5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJCCgtISktH" + "TUNIRkhGTRIRCglhdmF0YXJfaWQYBiABKA0SIAoLYXZhdGFyX3R5cGUYDyAB" + "KA4yCy5BdmF0YXJUeXBlQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { AvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HJKGMCHFHFM), HJKGMCHFHFM.Parser, new string[2] { "AvatarId", "AvatarType" }, null, null, null, null)
		}));
	}
}
