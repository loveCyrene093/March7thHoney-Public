using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BAAMEJNMMOBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BAAMEJNMMOBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCQUFNRUpOTU1PQi5wcm90byIiCgtCQUFNRUpOTU1PQhITCgtQS0lETlBQ" + "RkJJTxgLIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BAAMEJNMMOB), BAAMEJNMMOB.Parser, new string[1] { "PKIDNPPFBIO" }, null, null, null, null)
		}));
	}
}
