using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ADJBBLEBIENReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ADJBBLEBIENReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBREpCQkxFQklFTi5wcm90byIiCgtBREpCQkxFQklFThITCgtERE1LQ09C" + "T01OTxgJIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ADJBBLEBIEN), ADJBBLEBIEN.Parser, new string[1] { "DDMKCOBOMNO" }, null, null, null, null)
		}));
	}
}
