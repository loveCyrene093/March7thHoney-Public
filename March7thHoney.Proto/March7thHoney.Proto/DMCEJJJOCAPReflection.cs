using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DMCEJJJOCAPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DMCEJJJOCAPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFETUNFSkpKT0NBUC5wcm90bxoRT0JDRkpQR05BTFAucHJvdG8iQAoLRE1D" + "RUpKSk9DQVASHAoGcmVhc29uGAcgASgOMgwuT0JDRkpQR05BTFASEwoLSkxF" + "SUxPR0xKTkoYDiABKARCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[1] { OBCFJPGNALPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DMCEJJJOCAP), DMCEJJJOCAP.Parser, new string[2] { "Reason", "JLEILOGLJNJ" }, null, null, null, null)
		}));
	}
}
