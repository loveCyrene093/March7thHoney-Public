using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OIJJDMGODJPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OIJJDMGODJPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPSUpKRE1HT0RKUC5wcm90bxoRRkhDQ0NISkhIS0wucHJvdG8iPAoLT0lK" + "SkRNR09ESlASDwoHcmV0Y29kZRgBIAEoDRIcCgZsaW5ldXAYBCABKAsyDC5G" + "SENDQ0hKSEhLTEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { FHCCCHJHHKLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OIJJDMGODJP), OIJJDMGODJP.Parser, new string[2] { "Retcode", "Lineup" }, null, null, null, null)
		}));
	}
}
