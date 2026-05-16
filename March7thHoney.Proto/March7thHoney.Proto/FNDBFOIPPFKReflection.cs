using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FNDBFOIPPFKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FNDBFOIPPFKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGTkRCRk9JUFBGSy5wcm90byIiCgtGTkRCRk9JUFBGSxITCgtEQkZOSk9Q" + "SUFGRRgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FNDBFOIPPFK), FNDBFOIPPFK.Parser, new string[1] { "DBFNJOPIAFE" }, null, null, null, null)
		}));
	}
}
