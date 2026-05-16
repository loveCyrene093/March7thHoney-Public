using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeartDialScriptInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeartDialScriptInfoReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChlIZWFydERpYWxTY3JpcHRJbmZvLnByb3RvGhpIZWFydERpYWxFbW90aW9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "VHlwZS5wcm90bxoXSGVhcnREaWFsU3RlcFR5cGUucHJvdG8ipQEKE0hlYXJ0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "RGlhbFNjcmlwdEluZm8SEwoLR0tPQUxCQVBJSEIYBCABKAgSIAoEc3RlcBgK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "IAEoDjISLkhlYXJ0RGlhbFN0ZXBUeXBlEi8KEGN1cl9lbW90aW9uX3R5cGUY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "DCABKA4yFS5IZWFydERpYWxFbW90aW9uVHlwZRITCgtIUE5JTklKRU9CSBgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "IAEoCBIRCglzY3JpcHRfaWQYDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[2]
		{
			HeartDialEmotionTypeReflection.Descriptor,
			HeartDialStepTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HeartDialScriptInfo), HeartDialScriptInfo.Parser, new string[5] { "GKOALBAPIHB", "Step", "CurEmotionType", "HPNINIJEOBH", "ScriptId" }, null, null, null, null)
		}));
	}
}
