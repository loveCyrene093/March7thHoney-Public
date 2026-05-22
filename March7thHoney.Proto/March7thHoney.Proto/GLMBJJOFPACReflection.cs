using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GLMBJJOFPACReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GLMBJJOFPACReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHTE1CSkpPRlBBQy5wcm90byI2CgtHTE1CSkpPRlBBQxIRCglhdmF0YXJf" + "aWQYASABKA0SFAoMYXZhdGFyX2xldmVsGAIgASgNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GLMBJJOFPAC), GLMBJJOFPAC.Parser, new string[2] { "AvatarId", "AvatarLevel" }, null, null, null, null)
		}));
	}
}
