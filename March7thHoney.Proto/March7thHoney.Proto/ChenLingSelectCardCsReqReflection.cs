using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChenLingSelectCardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChenLingSelectCardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1DaGVuTGluZ1NlbGVjdENhcmRDc1JlcS5wcm90byIuChdDaGVuTGluZ1Nl" + "bGVjdENhcmRDc1JlcRITCgtFQ0RITElISVBNRRgEIAEoDUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChenLingSelectCardCsReq), ChenLingSelectCardCsReq.Parser, new string[1] { "ECDHLIHIPME" }, null, null, null, null)
		}));
	}
}
