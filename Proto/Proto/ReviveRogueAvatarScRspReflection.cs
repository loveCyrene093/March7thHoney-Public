using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ReviveRogueAvatarScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ReviveRogueAvatarScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChxSZXZpdmVSb2d1ZUF2YXRhclNjUnNwLnByb3RvGhFKTFBHSUdQQ0lBRy5w";
		buffer[1] = "cm90byJpChZSZXZpdmVSb2d1ZUF2YXRhclNjUnNwEg8KB3JldGNvZGUYAiAB";
		buffer[2] = "KA0SIQoLUEFNR0hNREpBSkEYCSABKAsyDC5KTFBHSUdQQ0lBRxIbChNiYXNl";
		buffer[3] = "X2F2YXRhcl9pZF9saXN0GA8gAygNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		buffer[4] = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { JLPGIGPCIAGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ReviveRogueAvatarScRsp), ReviveRogueAvatarScRsp.Parser, new string[3] { "Retcode", "PAMGHMDJAJA", "BaseAvatarIdList" }, null, null, null, null)
		}));
	}
}
