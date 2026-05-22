using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetAssistCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetAssistCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRTZXRBc3Npc3RDc1JlcS5wcm90byIwCg5TZXRBc3Npc3RDc1JlcRIRCglh" + "dmF0YXJfaWQYAiABKA0SCwoDdWlkGA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetAssistCsReq), SetAssistCsReq.Parser, new string[2] { "AvatarId", "Uid" }, null, null, null, null)
		}));
	}
}
