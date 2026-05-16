using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetHipplenAgendaCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetHipplenAgendaCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtTZXRIaXBwbGVuQWdlbmRhQ3NSZXEucHJvdG8iLAoVU2V0SGlwcGxlbkFn" + "ZW5kYUNzUmVxEhMKC0NMS0FJTERDUEpDGAcgAygNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetHipplenAgendaCsReq), SetHipplenAgendaCsReq.Parser, new string[1] { "CLKAILDCPJC" }, null, null, null, null)
		}));
	}
}
