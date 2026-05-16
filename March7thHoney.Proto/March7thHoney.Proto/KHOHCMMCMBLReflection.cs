using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KHOHCMMCMBLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KHOHCMMCMBLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLSE9IQ01NQ01CTC5wcm90bxoRTkpCSEtMQ0tIQksucHJvdG8iQQoLS0hP" + "SENNTUNNQkwSIQoLTUFPTkhEQ0NIUEUYCCABKAsyDC5OSkJIS0xDS0hCSxIP" + "CgdyZXRjb2RlGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { NJBHKLCKHBKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KHOHCMMCMBL), KHOHCMMCMBL.Parser, new string[2] { "MAONHDCCHPE", "Retcode" }, null, null, null, null)
		}));
	}
}
