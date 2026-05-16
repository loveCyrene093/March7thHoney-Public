using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LOPDMEPEDFGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LOPDMEPEDFGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMT1BETUVQRURGRy5wcm90bypkCgtMT1BETUVQRURGRxIbChdMT1BETUVQ" + "RURGR19FTUlFRFBLQlBLSRAAEhsKF0xPUERNRVBFREZHX0xHSEVKSkdGS0lN" + "EAESGwoXTE9QRE1FUEVERkdfR0FQTk1DS0NKQ0cQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(LOPDMEPEDFG) }, null, null));
	}
}
