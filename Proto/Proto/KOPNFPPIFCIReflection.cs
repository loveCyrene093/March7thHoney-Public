using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KOPNFPPIFCIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KOPNFPPIFCIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLT1BORlBQSUZDSS5wcm90byI3CgtLT1BORlBQSUZDSRITCgtQSUFDQUNO" + "TkJOSBgCIAEoDRITCgtJQ09HQUhGRkNMRBgPIAEoCEIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KOPNFPPIFCI), KOPNFPPIFCI.Parser, new string[2] { "PIACACNNBNH", "ICOGAHFFCLD" }, null, null, null, null)
		}));
	}
}
