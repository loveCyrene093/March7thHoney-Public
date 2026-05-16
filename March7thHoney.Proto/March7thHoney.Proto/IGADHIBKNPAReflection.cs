using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IGADHIBKNPAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IGADHIBKNPAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJR0FESElCS05QQS5wcm90byJhCgtJR0FESElCS05QQRITCgtLQ0ZQSUdD" + "RUhJRxgBIAEoDRITCgtOSUZIRk9ITENFRBgCIAEoDRITCgtLSUVOSEVOTkFL" + "ShgDIAEoARITCgtOQk1OSENNSkRGTxgEIAEoAUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IGADHIBKNPA), IGADHIBKNPA.Parser, new string[4] { "KCFPIGCEHIG", "NIFHFOHLCED", "KIENHENNAKJ", "NBMNHCMJDFO" }, null, null, null, null)
		}));
	}
}
