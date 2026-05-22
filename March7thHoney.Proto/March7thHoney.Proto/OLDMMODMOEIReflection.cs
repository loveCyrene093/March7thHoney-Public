using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OLDMMODMOEIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OLDMMODMOEIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPTERNTU9ETU9FSS5wcm90bxoRTU5DT1BETkVMTUMucHJvdG8iRQoLT0xE" + "TU1PRE1PRUkSIQoLUFBJUEZPUEhOSE0YBiABKAsyDC5NTkNPUERORUxNQxIT" + "CgtISkJPQkNMRUVESRgLIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { MNCOPDNELMCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OLDMMODMOEI), OLDMMODMOEI.Parser, new string[2] { "PPIPFOPHNHM", "HJBOBCLEEDI" }, null, null, null, null)
		}));
	}
}
