using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CNHNGLEEBKPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CNHNGLEEBKPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDTkhOR0xFRUJLUC5wcm90byJTCgtDTkhOR0xFRUJLUBITCgtMR0hPT0tN" + "Tk1DTBgBIAEoDRILCgNleHAYCCABKA0SDQoFbGV2ZWwYDCABKA0SEwoLTU9P" + "T1BBTUJPRksYDiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CNHNGLEEBKP), CNHNGLEEBKP.Parser, new string[4] { "LGHOOKMNMCL", "Exp", "Level", "MOOOPAMBOFK" }, null, null, null, null)
		}));
	}
}
