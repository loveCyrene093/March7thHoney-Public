using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KGJCEOFKEHAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KGJCEOFKEHAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLR0pDRU9GS0VIQS5wcm90bxoRUEJQSU9GR09ESEMucHJvdG8iQQoLS0dK" + "Q0VPRktFSEESIQoLTUhNRElES05DSUgYAyABKAsyDC5QQlBJT0ZHT0RIQxIP" + "CgdyZXRjb2RlGAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { PBPIOFGODHCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KGJCEOFKEHA), KGJCEOFKEHA.Parser, new string[2] { "MHMDIDKNCIH", "Retcode" }, null, null, null, null)
		}));
	}
}
