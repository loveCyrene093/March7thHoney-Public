using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishCurTurnCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishCurTurnCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhGaW5pc2hDdXJUdXJuQ3NSZXEucHJvdG8iKQoSRmluaXNoQ3VyVHVybkNz" + "UmVxEhMKC05PSUJDSE1ESEpIGAEgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishCurTurnCsReq), FinishCurTurnCsReq.Parser, new string[1] { "NOIBCHMDHJH" }, null, null, null, null)
		}));
	}
}
