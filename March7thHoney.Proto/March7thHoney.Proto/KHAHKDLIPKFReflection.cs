using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KHAHKDLIPKFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KHAHKDLIPKFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLSEFIS0RMSVBLRi5wcm90bxoRSkRLQUpNRVBFQ0YucHJvdG8iRQoLS0hB" + "SEtETElQS0YSIQoLT0tCTENOR0ZIQ0wYAiADKAsyDC5KREtBSk1FUEVDRhIT" + "CgtKTkxEUEZITU9KTBgNIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { JDKAJMEPECFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KHAHKDLIPKF), KHAHKDLIPKF.Parser, new string[2] { "OKBLCNGFHCL", "JNLDPFHMOJL" }, null, null, null, null)
		}));
	}
}
