using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CGPFNCNAMOPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CGPFNCNAMOPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDR1BGTkNOQU1PUC5wcm90bxoRSElEUEpQTkZDS08ucHJvdG8iMAoLQ0dQ" + "Rk5DTkFNT1ASIQoLS0dOQkpMQkxNUEoYBSADKAsyDC5ISURQSlBORkNLT0IW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { HIDPJPNFCKOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CGPFNCNAMOP), CGPFNCNAMOP.Parser, new string[1] { "KGNBJLBLMPJ" }, null, null, null, null)
		}));
	}
}
