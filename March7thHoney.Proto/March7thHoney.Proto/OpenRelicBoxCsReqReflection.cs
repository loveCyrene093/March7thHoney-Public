using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OpenRelicBoxCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OpenRelicBoxCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdPcGVuUmVsaWNCb3hDc1JlcS5wcm90bxoRT01IQU9CRktJS0UucHJvdG8i" + "NgoRT3BlblJlbGljQm94Q3NSZXESIQoLR1BFQUZBSkdDUEgYBiABKAsyDC5P" + "TUhBT0JGS0lLRUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { OMHAOBFKIKEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OpenRelicBoxCsReq), OpenRelicBoxCsReq.Parser, new string[1] { "GPEAFAJGCPH" }, null, null, null, null)
		}));
	}
}
