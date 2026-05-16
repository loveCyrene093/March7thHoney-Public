using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterRogueScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterRogueScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChVFbnRlclJvZ3VlU2NSc3AucHJvdG8aEUpQRkdIQ1BHSEdPLnByb3RvGhBM";
		buffer[1] = "aW5ldXBJbmZvLnByb3RvGhFNQURFRU5BQk9LRS5wcm90bxoPU2NlbmVJbmZv";
		buffer[2] = "LnByb3RvIqQBCg9FbnRlclJvZ3VlU2NSc3ASIQoLRU5QQUlDTkxDTUsYAiAB";
		buffer[3] = "KAsyDC5NQURFRU5BQk9LRRIlCg9yb2d1ZV9nYW1lX2luZm8YAyABKAsyDC5K";
		buffer[4] = "UEZHSENQR0hHTxIZCgVzY2VuZRgHIAEoCzIKLlNjZW5lSW5mbxIPCgdyZXRj";
		buffer[5] = "b2RlGA0gASgNEhsKBmxpbmV1cBgPIAEoCzILLkxpbmV1cEluZm9CFqoCE01h";
		buffer[6] = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
		{
			JPFGHCPGHGOReflection.Descriptor,
			LineupInfoReflection.Descriptor,
			MADEENABOKEReflection.Descriptor,
			SceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterRogueScRsp), EnterRogueScRsp.Parser, new string[5] { "ENPAICNLCMK", "RogueGameInfo", "Scene", "Retcode", "Lineup" }, null, null, null, null)
		}));
	}
}
