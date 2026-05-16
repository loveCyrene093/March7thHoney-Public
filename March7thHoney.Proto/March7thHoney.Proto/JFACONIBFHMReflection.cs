using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JFACONIBFHMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JFACONIBFHMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKRkFDT05JQkZITS5wcm90bxoRT0VHSUNDRkdISkUucHJvdG8iTwoLSkZB" + "Q09OSUJGSE0SHQoVZ3JpZF9maWdodF90cmFpdF9pbmZvGAUgAygNEiEKC0VP" + "TkVOTExCR0VOGAwgAygLMgwuT0VHSUNDRkdISkVCFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { OEGICCFGHJEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JFACONIBFHM), JFACONIBFHM.Parser, new string[2] { "GridFightTraitInfo", "EONENLLBGEN" }, null, null, null, null)
		}));
	}
}
