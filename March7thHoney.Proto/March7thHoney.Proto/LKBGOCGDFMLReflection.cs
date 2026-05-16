using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LKBGOCGDFMLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LKBGOCGDFMLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMS0JHT0NHREZNTC5wcm90bxoRTEhQUElBS0tGTUUucHJvdG8iQwoLTEtC" + "R09DR0RGTUwSEQoJcm9sZV9zdGFyGAEgASgNEiEKC1BHTk1ESklJS0pCGAIg" + "AygLMgwuTEhQUElBS0tGTUVCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[1] { LHPPIAKKFMEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LKBGOCGDFML), LKBGOCGDFML.Parser, new string[2] { "RoleStar", "PGNMDJIIKJB" }, null, null, null, null)
		}));
	}
}
