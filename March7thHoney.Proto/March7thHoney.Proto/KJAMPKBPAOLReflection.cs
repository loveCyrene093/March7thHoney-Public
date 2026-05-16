using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KJAMPKBPAOLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KJAMPKBPAOLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLSkFNUEtCUEFPTC5wcm90byIiCgtLSkFNUEtCUEFPTBITCgtQSkJPR0pJ" + "SE5HShgPIAEoA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KJAMPKBPAOL), KJAMPKBPAOL.Parser, new string[1] { "PJBOGJIHNGJ" }, null, null, null, null)
		}));
	}
}
