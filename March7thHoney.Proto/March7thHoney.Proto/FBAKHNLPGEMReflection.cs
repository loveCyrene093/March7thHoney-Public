using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FBAKHNLPGEMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FBAKHNLPGEMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGQkFLSE5MUEdFTS5wcm90bxoRRExDQ09KUEhCQ0IucHJvdG8aEUZNQU5Q" + "Q0tHRkRELnByb3RvIk4KC0ZCQUtITkxQR0VNEiEKC0hHUEdEQ09DREZLGAwg" + "ASgLMgwuRExDQ09KUEhCQ0ISHAoGcmVhc29uGA0gASgOMgwuRk1BTlBDS0dG" + "RERCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[2]
		{
			DLCCOJPHBCBReflection.Descriptor,
			FMANPCKGFDDReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FBAKHNLPGEM), FBAKHNLPGEM.Parser, new string[2] { "HGPGDCOCDFK", "Reason" }, null, null, null, null)
		}));
	}
}
