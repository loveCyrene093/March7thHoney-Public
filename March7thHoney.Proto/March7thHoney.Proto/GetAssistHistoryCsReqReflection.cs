using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAssistHistoryCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAssistHistoryCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRBc3Npc3RIaXN0b3J5Q3NSZXEucHJvdG8iFwoVR2V0QXNzaXN0SGlz" + "dG9yeUNzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAssistHistoryCsReq), GetAssistHistoryCsReq.Parser, null, null, null, null, null)
		}));
	}
}
