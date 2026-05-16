using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ScenePropInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ScenePropInfoReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChNTY2VuZVByb3BJbmZvLnByb3RvGhNQcm9wRXh0cmFJbmZvLnByb3RvIqEB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "Cg1TY2VuZVByb3BJbmZvEhQKDGxpZmVfdGltZV9tcxgBIAEoDRISCgpwcm9w";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "X3N0YXRlGAIgASgNEhkKEXRyaWdnZXJfbmFtZV9saXN0GAYgAygJEiIKCmV4";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "dHJhX2luZm8YCSABKAsyDi5Qcm9wRXh0cmFJbmZvEhYKDmNyZWF0ZV90aW1l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "X21zGAwgASgEEg8KB3Byb3BfaWQYDyABKA1CFqoCE01hcmNoN3RoSG9uZXku";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { PropExtraInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ScenePropInfo), ScenePropInfo.Parser, new string[6] { "LifeTimeMs", "PropState", "TriggerNameList", "ExtraInfo", "CreateTimeMs", "PropId" }, null, null, null, null)
		}));
	}
}
