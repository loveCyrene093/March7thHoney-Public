using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BLMLCCDEOPPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BLMLCCDEOPPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCTE1MQ0NERU9QUC5wcm90byIiCgtCTE1MQ0NERU9QUBITCgtKQkNDSkxM" + "QkJBSxgGIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BLMLCCDEOPP), BLMLCCDEOPP.Parser, new string[1] { "JBCCJLLBBAK" }, null, null, null, null)
		}));
	}
}
