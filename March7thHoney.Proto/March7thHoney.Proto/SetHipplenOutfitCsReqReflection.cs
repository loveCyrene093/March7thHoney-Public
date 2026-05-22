using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetHipplenOutfitCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetHipplenOutfitCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtTZXRIaXBwbGVuT3V0Zml0Q3NSZXEucHJvdG8iLAoVU2V0SGlwcGxlbk91" + "dGZpdENzUmVxEhMKC0ZLRUdNTUtOSE9OGA4gASgNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetHipplenOutfitCsReq), SetHipplenOutfitCsReq.Parser, new string[1] { "FKEGMMKNHON" }, null, null, null, null)
		}));
	}
}
