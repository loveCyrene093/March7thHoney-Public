using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DPPDCNBILMNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DPPDCNBILMNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFEUFBEQ05CSUxNTi5wcm90bxoRTkpCSEtMQ0tIQksucHJvdG8iQQoLRFBQ" + "RENOQklMTU4SIQoLTUFPTkhEQ0NIUEUYAyABKAsyDC5OSkJIS0xDS0hCSxIP" + "CgdyZXRjb2RlGAsgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { NJBHKLCKHBKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DPPDCNBILMN), DPPDCNBILMN.Parser, new string[2] { "MAONHDCCHPE", "Retcode" }, null, null, null, null)
		}));
	}
}
