using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DPPJIOPGKJIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DPPJIOPGKJIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFEUFBKSU9QR0tKSS5wcm90bxoRUEJQSU9GR09ESEMucHJvdG8iQQoLRFBQ" + "SklPUEdLSkkSIQoLTUhNRElES05DSUgYAiABKAsyDC5QQlBJT0ZHT0RIQxIP" + "CgdyZXRjb2RlGAcgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { PBPIOFGODHCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DPPJIOPGKJI), DPPJIOPGKJI.Parser, new string[2] { "MHMDIDKNCIH", "Retcode" }, null, null, null, null)
		}));
	}
}
