using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NEODBNGBBDOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NEODBNGBBDOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFORU9EQk5HQkJETy5wcm90byIiCgtORU9EQk5HQkJETxITCgtOTVBHTktJ" + "TlBMTBgBIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NEODBNGBBDO), NEODBNGBBDO.Parser, new string[1] { "NMPGNKINPLL" }, null, null, null, null)
		}));
	}
}
