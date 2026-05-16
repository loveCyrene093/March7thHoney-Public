using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ALEOPCNHNPDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ALEOPCNHNPDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBTEVPUENOSE5QRC5wcm90byI3CgtBTEVPUENOSE5QRBITCgtBQUFCT09G" + "QUZMShgBIAEoDRITCgtGRE1FRklJSkxDSxgHIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ALEOPCNHNPD), ALEOPCNHNPD.Parser, new string[2] { "AAABOOFAFLJ", "FDMEFIIJLCK" }, null, null, null, null)
		}));
	}
}
