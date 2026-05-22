using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterRogueMapRoomScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterRogueMapRoomScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChxFbnRlclJvZ3VlTWFwUm9vbVNjUnNwLnByb3RvGhBMaW5ldXBJbmZvLnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "b3RvGhFNQURFRU5BQk9LRS5wcm90bxoPU2NlbmVJbmZvLnByb3RvIpkBChZF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "bnRlclJvZ3VlTWFwUm9vbVNjUnNwEhsKBmxpbmV1cBgBIAEoCzILLkxpbmV1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "cEluZm8SDwoHcmV0Y29kZRgDIAEoDRIZCgVzY2VuZRgIIAEoCzIKLlNjZW5l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "SW5mbxITCgtIRUlPTlBESUZOTRgJIAEoDRIhCgtFTlBBSUNOTENNSxgKIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "CzIMLk1BREVFTkFCT0tFQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[3]
		{
			LineupInfoReflection.Descriptor,
			MADEENABOKEReflection.Descriptor,
			SceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterRogueMapRoomScRsp), EnterRogueMapRoomScRsp.Parser, new string[5] { "Lineup", "Retcode", "Scene", "HEIONPDIFNM", "ENPAICNLCMK" }, null, null, null, null)
		}));
	}
}
