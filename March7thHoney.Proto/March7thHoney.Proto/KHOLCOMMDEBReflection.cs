using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KHOLCOMMDEBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KHOLCOMMDEBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLSE9MQ09NTURFQi5wcm90byIiCgtLSE9MQ09NTURFQhITCgtET01HTEhJ" + "S0pFRBgIIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KHOLCOMMDEB), KHOLCOMMDEB.Parser, new string[1] { "DOMGLHIKJED" }, null, null, null, null)
		}));
	}
}
