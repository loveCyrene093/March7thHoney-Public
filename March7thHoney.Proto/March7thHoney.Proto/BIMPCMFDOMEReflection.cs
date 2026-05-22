using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BIMPCMFDOMEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BIMPCMFDOMEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCSU1QQ01GRE9NRS5wcm90byIiCgtCSU1QQ01GRE9NRRITCgtNUExITkZN" + "RkNQUBgLIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BIMPCMFDOME), BIMPCMFDOME.Parser, new string[1] { "MPLHNFMFCPP" }, null, null, null, null)
		}));
	}
}
