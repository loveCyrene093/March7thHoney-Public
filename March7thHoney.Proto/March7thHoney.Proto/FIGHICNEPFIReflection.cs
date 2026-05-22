using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FIGHICNEPFIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FIGHICNEPFIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGSUdISUNORVBGSS5wcm90byI3CgtGSUdISUNORVBGSRITCgtCUEVPRUNB" + "R0lJRxgBIAMoDRITCgtJUERDQkVNSElNRxgCIAMoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FIGHICNEPFI), FIGHICNEPFI.Parser, new string[2] { "BPEOECAGIIG", "IPDCBEMHIMG" }, null, null, null, null)
		}));
	}
}
