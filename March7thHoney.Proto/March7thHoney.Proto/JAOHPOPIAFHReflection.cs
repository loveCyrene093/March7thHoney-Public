using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JAOHPOPIAFHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JAOHPOPIAFHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKQU9IUE9QSUFGSC5wcm90byJiCgtKQU9IUE9QSUFGSBITCgtOQ0ZIR0lC" + "Q0VCRxgBIAEoDRITCgtIQ0pQRE5ET0hBTRgCIAEoDRIUCgxkaWNlX3Nsb3Rf" + "aWQYAyABKA0SEwoLSUJIS09HUEVJQ04YBCABKANCFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JAOHPOPIAFH), JAOHPOPIAFH.Parser, new string[4] { "NCFHGIBCEBG", "HCJPDNDOHAM", "DiceSlotId", "IBHKOGPEICN" }, null, null, null, null)
		}));
	}
}
