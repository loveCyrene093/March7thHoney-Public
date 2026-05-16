using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FMGJFLEPDBBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FMGJFLEPDBBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGTUdKRkxFUERCQi5wcm90byIiCgtGTUdKRkxFUERCQhITCgtERUpBSENQ" + "RkVJRBgKIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FMGJFLEPDBB), FMGJFLEPDBB.Parser, new string[1] { "DEJAHCPFEID" }, null, null, null, null)
		}));
	}
}
