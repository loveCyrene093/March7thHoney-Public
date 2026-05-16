using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RestartChallengePhaseScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RestartChallengePhaseScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXN0YXJ0Q2hhbGxlbmdlUGhhc2VTY1JzcC5wcm90bxoPU2NlbmVJbmZv" + "LnByb3RvIkgKGlJlc3RhcnRDaGFsbGVuZ2VQaGFzZVNjUnNwEhkKBXNjZW5l" + "GAEgASgLMgouU2NlbmVJbmZvEg8KB3JldGNvZGUYDiABKA1CFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { SceneInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RestartChallengePhaseScRsp), RestartChallengePhaseScRsp.Parser, new string[2] { "Scene", "Retcode" }, null, null, null, null)
		}));
	}
}
