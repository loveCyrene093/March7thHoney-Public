using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OHMDKPCOAECReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OHMDKPCOAECReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPSE1ES1BDT0FFQy5wcm90byINCgtPSE1ES1BDT0FFQ0IWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OHMDKPCOAEC), OHMDKPCOAEC.Parser, null, null, null, null, null)
		}));
	}
}
