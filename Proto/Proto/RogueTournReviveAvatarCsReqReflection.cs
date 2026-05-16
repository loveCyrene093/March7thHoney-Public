using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournReviveAvatarCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournReviveAvatarCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiFSb2d1ZVRvdXJuUmV2aXZlQXZhdGFyQ3NSZXEucHJvdG8aEUhEREJKSUtO";
		buffer[1] = "RVBGLnByb3RvImMKG1JvZ3VlVG91cm5SZXZpdmVBdmF0YXJDc1JlcRIhChlp";
		buffer[2] = "bnRlcmFjdGVkX3Byb3BfZW50aXR5X2lkGAIgASgNEiEKC2F2YXRhcl9saXN0";
		buffer[3] = "GAsgAygLMgwuSEREQkpJS05FUEZCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		buffer[4] = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { HDDBJIKNEPFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournReviveAvatarCsReq), RogueTournReviveAvatarCsReq.Parser, new string[2] { "InteractedPropEntityId", "AvatarList" }, null, null, null, null)
		}));
	}
}
