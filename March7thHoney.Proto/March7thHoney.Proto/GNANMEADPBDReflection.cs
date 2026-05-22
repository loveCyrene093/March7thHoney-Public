using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GNANMEADPBDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GNANMEADPBDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHTkFOTUVBRFBCRC5wcm90byJeCgtHTkFOTUVBRFBCRBITCgtJUENGT0ZI" + "TEFIRxgEIAMoDRITCgtETk5IQ05DS0pDTRgIIAEoAxITCgtETkhGUEJPUEZB" + "ShgKIAEoDRIQCghlbmRfdGltZRgMIAEoA0IWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GNANMEADPBD), GNANMEADPBD.Parser, new string[4] { "IPCFOFHLAHG", "DNNHCNCKJCM", "DNHFPBOPFAJ", "EndTime" }, null, null, null, null)
		}));
	}
}
