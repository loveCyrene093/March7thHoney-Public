using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NGPKKAMADNAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NGPKKAMADNAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOR1BLS0FNQUROQS5wcm90byIiCgtOR1BLS0FNQUROQRITCgtCR0xMQ0xM" + "S05KTRgBIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NGPKKAMADNA), NGPKKAMADNA.Parser, new string[1] { "BGLLCLLKNJM" }, null, null, null, null)
		}));
	}
}
