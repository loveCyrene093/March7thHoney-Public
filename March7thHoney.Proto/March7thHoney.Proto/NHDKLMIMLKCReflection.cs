using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NHDKLMIMLKCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NHDKLMIMLKCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOSERLTE1JTUxLQy5wcm90byJzCgtOSERLTE1JTUxLQxITCgtQR01KUExM" + "TklBSxgDIAEoDRIQCghlbmRfdGltZRgFIAEoAxITCgtETk5IQ05DS0pDTRgJ" + "IAEoAxITCgtNSURLTUlJRFBIRhgLIAEoCBITCgtJUENGT0ZITEFIRxgMIAMo" + "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NHDKLMIMLKC), NHDKLMIMLKC.Parser, new string[5] { "PGMJPLLNIAK", "EndTime", "DNNHCNCKJCM", "MIDKMIIDPHF", "IPCFOFHLAHG" }, null, null, null, null)
		}));
	}
}
