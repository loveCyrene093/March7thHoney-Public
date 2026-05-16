using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ALMCIEPOODPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ALMCIEPOODPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBTE1DSUVQT09EUC5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJCCgtBTE1D" + "SUVQT09EUBIRCglhdmF0YXJfaWQYAiABKA0SIAoLYXZhdGFyX3R5cGUYDyAB" + "KA4yCy5BdmF0YXJUeXBlQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { AvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ALMCIEPOODP), ALMCIEPOODP.Parser, new string[2] { "AvatarId", "AvatarType" }, null, null, null, null)
		}));
	}
}
