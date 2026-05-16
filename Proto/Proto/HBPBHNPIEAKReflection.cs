using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HBPBHNPIEAKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HBPBHNPIEAKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIQlBCSE5QSUVBSy5wcm90bxoRTkpCSEtMQ0tIQksucHJvdG8iQQoLSEJQ" + "QkhOUElFQUsSIQoLTUFPTkhEQ0NIUEUYCSABKAsyDC5OSkJIS0xDS0hCSxIP" + "CgdyZXRjb2RlGAwgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { NJBHKLCKHBKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HBPBHNPIEAK), HBPBHNPIEAK.Parser, new string[2] { "MAONHDCCHPE", "Retcode" }, null, null, null, null)
		}));
	}
}
