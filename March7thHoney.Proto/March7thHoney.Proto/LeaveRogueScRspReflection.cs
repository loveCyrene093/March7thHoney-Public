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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChVMZWF2ZVJvZ3VlU2NSc3AucHJvdG8aEUpQRkdIQ1BHSEdPLnByb3RvGhBM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "aW5ldXBJbmZvLnByb3RvGhFNQURFRU5BQk9LRS5wcm90bxoPU2NlbmVJbmZv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "LnByb3RvIqQBCg9MZWF2ZVJvZ3VlU2NSc3ASDwoHcmV0Y29kZRgCIAEoDRIb";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "CgZsaW5ldXAYBSABKAsyCy5MaW5ldXBJbmZvEhkKBXNjZW5lGAggASgLMgou";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "U2NlbmVJbmZvEiUKD3JvZ3VlX2dhbWVfaW5mbxgJIAEoCzIMLkpQRkdIQ1BH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "SEdPEiEKC0VOUEFJQ05MQ01LGAogASgLMgwuTUFERUVOQUJPS0VCFqoCE01h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[4]
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
