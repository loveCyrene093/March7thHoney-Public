using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LeaveRogueScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LeaveRogueScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChVMZWF2ZVJvZ3VlU2NSc3AucHJvdG8aEUpQRkdIQ1BHSEdPLnByb3RvGhBM";
		buffer[1] = "aW5ldXBJbmZvLnByb3RvGhFNQURFRU5BQk9LRS5wcm90bxoPU2NlbmVJbmZv";
		buffer[2] = "LnByb3RvIqQBCg9MZWF2ZVJvZ3VlU2NSc3ASDwoHcmV0Y29kZRgCIAEoDRIb";
		buffer[3] = "CgZsaW5ldXAYBSABKAsyCy5MaW5ldXBJbmZvEhkKBXNjZW5lGAggASgLMgou";
		buffer[4] = "U2NlbmVJbmZvEiUKD3JvZ3VlX2dhbWVfaW5mbxgJIAEoCzIMLkpQRkdIQ1BH";
		buffer[5] = "SEdPEiEKC0VOUEFJQ05MQ01LGAogASgLMgwuTUFERUVOQUJPS0VCFqoCE01h";
		buffer[6] = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
		{
			JPFGHCPGHGOReflection.Descriptor,
			LineupInfoReflection.Descriptor,
			MADEENABOKEReflection.Descriptor,
			SceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LeaveRogueScRsp), LeaveRogueScRsp.Parser, new string[5] { "Retcode", "Lineup", "Scene", "RogueGameInfo", "ENPAICNLCMK" }, null, null, null, null)
		}));
	}
}
