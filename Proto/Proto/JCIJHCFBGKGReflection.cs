using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JCIJHCFBGKGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JCIJHCFBGKGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKQ0lKSENGQkdLRy5wcm90byJhCgtKQ0lKSENGQkdLRxITCgtDSkJCTUFK" + "SUFDSRgCIAEoDRITCgtBRkZBUExMRUJCTxgDIAEoDRITCgtNRUdDQUdOSE1J" + "RRgIIAEoDRITCgtFTkhPSU1MSUJKThgNIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JCIJHCFBGKG), JCIJHCFBGKG.Parser, new string[4] { "CJBBMAJIACI", "AFFAPLLEBBO", "MEGCAGNHMIE", "ENHOIMLIBJN" }, null, null, null, null)
		}));
	}
}
