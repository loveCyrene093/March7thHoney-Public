using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MEFMBPFDBEMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MEFMBPFDBEMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNRUZNQlBGREJFTS5wcm90bxoRTEdPUExJQUZMQ0sucHJvdG8iKQoLTUVG" + "TUJQRkRCRU0SGgoEZGF0YRgCIAEoCzIMLkxHT1BMSUFGTENLQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { LGOPLIAFLCKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MEFMBPFDBEM), MEFMBPFDBEM.Parser, new string[1] { "Data" }, null, null, null, null)
		}));
	}
}
