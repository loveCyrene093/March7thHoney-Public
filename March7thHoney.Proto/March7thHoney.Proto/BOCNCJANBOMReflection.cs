using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BOCNCJANBOMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BOCNCJANBOMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCT0NOQ0pBTkJPTS5wcm90byIiCgtCT0NOQ0pBTkJPTRITCgtDQkRCRkFO" + "SkdQQhgMIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BOCNCJANBOM), BOCNCJANBOM.Parser, new string[1] { "CBDBFANJGPB" }, null, null, null, null)
		}));
	}
}
