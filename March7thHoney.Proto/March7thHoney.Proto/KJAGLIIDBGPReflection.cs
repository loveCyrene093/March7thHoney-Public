using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KJAGLIIDBGPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KJAGLIIDBGPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLSkFHTElJREJHUC5wcm90bxoRTUNBQ0RGSENQSUUucHJvdG8iRQoLS0pB" + "R0xJSURCR1ASIQoLdGFsZW50X2luZm8YCCABKAsyDC5NQ0FDREZIQ1BJRRIT" + "CgtESkNBSkhJTURPTBgLIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { MCACDFHCPIEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KJAGLIIDBGP), KJAGLIIDBGP.Parser, new string[2] { "TalentInfo", "DJCAJHIMDOL" }, null, null, null, null)
		}));
	}
}
