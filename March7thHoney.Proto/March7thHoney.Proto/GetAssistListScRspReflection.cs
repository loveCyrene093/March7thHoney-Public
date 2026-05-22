using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAssistListScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAssistListScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhHZXRBc3Npc3RMaXN0U2NSc3AucHJvdG8aFlBsYXllckFzc2lzdEluZm8u" + "cHJvdG8iTQoSR2V0QXNzaXN0TGlzdFNjUnNwEg8KB3JldGNvZGUYBSABKA0S" + "JgoLYXNzaXN0X2xpc3QYCCADKAsyES5QbGF5ZXJBc3Npc3RJbmZvQhaqAhNN" + "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { PlayerAssistInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAssistListScRsp), GetAssistListScRsp.Parser, new string[2] { "Retcode", "AssistList" }, null, null, null, null)
		}));
	}
}
