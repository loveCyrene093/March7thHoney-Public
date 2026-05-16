using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MuseumRandomEventQueryCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MuseumRandomEventQueryCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFNdXNldW1SYW5kb21FdmVudFF1ZXJ5Q3NSZXEucHJvdG8iMgobTXVzZXVt" + "UmFuZG9tRXZlbnRRdWVyeUNzUmVxEhMKC0FDQk5ISktGRk1QGAUgASgFQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MuseumRandomEventQueryCsReq), MuseumRandomEventQueryCsReq.Parser, new string[1] { "ACBNHJKFFMP" }, null, null, null, null)
		}));
	}
}
