using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PFIFNMIIOHFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PFIFNMIIOHFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQRklGTk1JSU9IRi5wcm90bxoRREFHTEhJTE9DS0wucHJvdG8iQwoLUEZJ" + "Rk5NSUlPSEYSEQoJYXZhdGFyX2lkGAEgASgNEiEKC1BOQ0lIRk1JRk9MGAIg" + "AygLMgwuREFHTEhJTE9DS0xCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[1] { DAGLHILOCKLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PFIFNMIIOHF), PFIFNMIIOHF.Parser, new string[2] { "AvatarId", "PNCIHFMIFOL" }, null, null, null, null)
		}));
	}
}
