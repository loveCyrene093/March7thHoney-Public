using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HCGEGGGLOFIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HCGEGGGLOFIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIQ0dFR0dHTE9GSS5wcm90bxoRTUNBQ0RGSENQSUUucHJvdG8iRQoLSENH" + "RUdHR0xPRkkSIQoLTkpPTktBTlBKTE8YASABKAsyDC5NQ0FDREZIQ1BJRRIT" + "CgtNUEdESk9HSEtCSBgEIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { MCACDFHCPIEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HCGEGGGLOFI), HCGEGGGLOFI.Parser, new string[2] { "NJONKANPJLO", "MPGDJOGHKBH" }, null, null, null, null)
		}));
	}
}
