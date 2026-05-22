using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FJJNFNALLGAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FJJNFNALLGAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGSkpORk5BTExHQS5wcm90bxoRS0tOSElNR05NUEcucHJvdG8iagoLRkpK" + "TkZOQUxMR0ESDwoHcm9vbV9pZBgBIAEoCRITCgtKQUZOQ09NR0FCRxgCIAEo" + "DRISCgpzZWN0aW9uX2lkGAMgASgNEiEKC3BsYXllcl9pbmZvGAQgASgLMgwu" + "S0tOSElNR05NUEdCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { KKNHIMGNMPGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FJJNFNALLGA), FJJNFNALLGA.Parser, new string[4] { "RoomId", "JAFNCOMGABG", "SectionId", "PlayerInfo" }, null, null, null, null)
		}));
	}
}
