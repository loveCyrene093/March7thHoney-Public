using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartRogueScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartRogueScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChVTdGFydFJvZ3VlU2NSc3AucHJvdG8aEUpQRkdIQ1BHSEdPLnByb3RvGhBM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "aW5ldXBJbmZvLnByb3RvGhFNQURFRU5BQk9LRS5wcm90bxoPU2NlbmVJbmZv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "LnByb3RvIqQBCg9TdGFydFJvZ3VlU2NSc3ASIQoLRU5QQUlDTkxDTUsYASAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "KAsyDC5NQURFRU5BQk9LRRIPCgdyZXRjb2RlGAIgASgNEhkKBXNjZW5lGAQg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "ASgLMgouU2NlbmVJbmZvEhsKBmxpbmV1cBgGIAEoCzILLkxpbmV1cEluZm8S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "JQoPcm9ndWVfZ2FtZV9pbmZvGAggASgLMgwuSlBGR0hDUEdIR09CFqoCE01h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[4]
		{
			JPFGHCPGHGOReflection.Descriptor,
			LineupInfoReflection.Descriptor,
			MADEENABOKEReflection.Descriptor,
			SceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartRogueScRsp), StartRogueScRsp.Parser, new string[5] { "ENPAICNLCMK", "Retcode", "Scene", "Lineup", "RogueGameInfo" }, null, null, null, null)
		}));
	}
}
