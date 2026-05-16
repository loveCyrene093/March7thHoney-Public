using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PCAHGLCGODJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PCAHGLCGODJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQQ0FIR0xDR09ESi5wcm90byJhCgtQQ0FIR0xDR09EShITCgtEQ0JKTklM" + "RkJBRxgBIAMoDRITCgtBRlBQQUJCR1BLRhgCIAMoDRITCgtEQkxLQ0VEREhJ" + "UBgDIAMoDRITCgtMSkFQTkRBT0VFTxgEIAMoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PCAHGLCGODJ), PCAHGLCGODJ.Parser, new string[4] { "DCBJNILFBAG", "AFPPABBGPKF", "DBLKCEDDHIP", "LJAPNDAOEEO" }, null, null, null, null)
		}));
	}
}
