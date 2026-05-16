using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KIKKGAAPMKGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KIKKGAAPMKGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLSUtLR0FBUE1LRy5wcm90bxoRSE1KR0FETElPTkEucHJvdG8iRQoLS0lL" + "S0dBQVBNS0cSEwoLTkdFSElMRUVOS0MYBCABKA0SIQoLUFBQSExIQURDUEoY" + "DyABKAsyDC5ITUpHQURMSU9OQUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { HMJGADLIONAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KIKKGAAPMKG), KIKKGAAPMKG.Parser, new string[2] { "NGEHILEENKC", "PPPHLHADCPJ" }, null, null, null, null)
		}));
	}
}
