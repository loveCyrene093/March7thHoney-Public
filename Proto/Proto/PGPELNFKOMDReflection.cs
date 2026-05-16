using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PGPELNFKOMDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PGPELNFKOMDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQR1BFTE5GS09NRC5wcm90byJhCgtQR1BFTE5GS09NRBITCgtISk1HR0xB" + "TkhNTBgBIAEoDRITCgtNREZEQkFDQ0ZPSBgCIAEoARITCgtFRUhKUFBMSU5B" + "RRgDIAEoDRITCgticmVha190aW1lcxgEIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PGPELNFKOMD), PGPELNFKOMD.Parser, new string[4] { "HJMGGLANHML", "MDFDBACCFOH", "EEHJPPLINAE", "BreakTimes" }, null, null, null, null)
		}));
	}
}
