using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KBOJACAEADLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KBOJACAEADLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLQk9KQUNBRUFETC5wcm90bxoRQUdCTExGR09CS0UucHJvdG8iPgoLS0JP" + "SkFDQUVBREwSDAoEdHlwZRgBIAEoDRIhCgtBT09OR0tKUEtPQhgIIAEoCzIM" + "LkFHQkxMRkdPQktFQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { AGBLLFGOBKEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KBOJACAEADL), KBOJACAEADL.Parser, new string[2] { "Type", "AOONGKJPKOB" }, null, null, null, null)
		}));
	}
}
