using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HFBFFEBOAHLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HFBFFEBOAHLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIRkJGRkVCT0FITC5wcm90byI3CgtIRkJGRkVCT0FITBITCgtETk5IQ05D" + "S0pDTRgEIAEoAxITCgtIUEpMTklQQUhDSBgMIAEoA0IWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HFBFFEBOAHL), HFBFFEBOAHL.Parser, new string[2] { "DNNHCNCKJCM", "HPJLNIPAHCH" }, null, null, null, null)
		}));
	}
}
