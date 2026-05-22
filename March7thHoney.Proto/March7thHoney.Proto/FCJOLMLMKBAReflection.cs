using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FCJOLMLMKBAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FCJOLMLMKBAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGQ0pPTE1MTUtCQS5wcm90byIvCgtGQ0pPTE1MTUtCQRITCgtITkRIRlBB" + "QkJLRBgJIAEoDRILCgNjbnQYDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FCJOLMLMKBA), FCJOLMLMKBA.Parser, new string[2] { "HNDHFPABBKD", "Cnt" }, null, null, null, null)
		}));
	}
}
