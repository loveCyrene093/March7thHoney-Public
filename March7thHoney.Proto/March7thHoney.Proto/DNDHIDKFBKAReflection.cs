using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DNDHIDKFBKAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DNDHIDKFBKAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFETkRISURLRkJLQS5wcm90bxoRTkpCSEtMQ0tIQksucHJvdG8iQQoLRE5E" + "SElES0ZCS0ESIQoLTUFPTkhEQ0NIUEUYCCABKAsyDC5OSkJIS0xDS0hCSxIP" + "CgdyZXRjb2RlGA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { NJBHKLCKHBKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DNDHIDKFBKA), DNDHIDKFBKA.Parser, new string[2] { "MAONHDCCHPE", "Retcode" }, null, null, null, null)
		}));
	}
}
