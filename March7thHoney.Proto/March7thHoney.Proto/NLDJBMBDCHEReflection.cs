using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NLDJBMBDCHEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NLDJBMBDCHEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOTERKQk1CRENIRS5wcm90bxoRT0JKR0dKUEZMQUUucHJvdG8iRQoLTkxE" + "SkJNQkRDSEUSIQoLRU1PSUdQTkJPT0wYCCABKAsyDC5PQkpHR0pQRkxBRRIT" + "CgtQRkRLS0ZQUEFBQRgJIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { OBJGGJPFLAEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NLDJBMBDCHE), NLDJBMBDCHE.Parser, new string[2] { "EMOIGPNBOOL", "PFDKKFPPAAA" }, null, null, null, null)
		}));
	}
}
