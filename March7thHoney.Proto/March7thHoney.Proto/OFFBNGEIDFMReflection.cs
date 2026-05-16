using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OFFBNGEIDFMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OFFBNGEIDFMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPRkZCTkdFSURGTS5wcm90bxoMVmVjdG9yLnByb3RvIisKC09GRkJOR0VJ" + "REZNEhwKC0dHRFBBQUpGTUpCGA8gASgLMgcuVmVjdG9yQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { VectorReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OFFBNGEIDFM), OFFBNGEIDFM.Parser, new string[1] { "GGDPAAJFMJB" }, null, null, null, null)
		}));
	}
}
