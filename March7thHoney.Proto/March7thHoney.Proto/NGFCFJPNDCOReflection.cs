using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NGFCFJPNDCOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NGFCFJPNDCOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOR0ZDRkpQTkRDTy5wcm90byINCgtOR0ZDRkpQTkRDT0IWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NGFCFJPNDCO), NGFCFJPNDCO.Parser, null, null, null, null, null)
		}));
	}
}
