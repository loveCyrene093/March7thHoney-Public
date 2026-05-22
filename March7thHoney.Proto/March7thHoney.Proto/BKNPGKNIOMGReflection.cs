using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BKNPGKNIOMGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BKNPGKNIOMGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCS05QR0tOSU9NRy5wcm90byI3CgtCS05QR0tOSU9NRxITCgtFS0lNTElB" + "TUZIRRgBIAEoDRITCgtQRE1NRE5KTUlLTRgJIAMoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BKNPGKNIOMG), BKNPGKNIOMG.Parser, new string[2] { "EKIMLIAMFHE", "PDMMDNJMIKM" }, null, null, null, null)
		}));
	}
}
