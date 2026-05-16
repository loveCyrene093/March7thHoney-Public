using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChangeScriptEmotionScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChangeScriptEmotionScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Ch5DaGFuZ2VTY3JpcHRFbW90aW9uU2NSc3AucHJvdG8aGkhlYXJ0RGlhbEVt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "b3Rpb25UeXBlLnByb3RvImsKGENoYW5nZVNjcmlwdEVtb3Rpb25TY1JzcBIP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "CgdyZXRjb2RlGAIgASgNEisKDGVtb3Rpb25fdHlwZRgJIAEoDjIVLkhlYXJ0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "RGlhbEVtb3Rpb25UeXBlEhEKCXNjcmlwdF9pZBgOIAEoDUIWqgITTWFyY2g3";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { HeartDialEmotionTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChangeScriptEmotionScRsp), ChangeScriptEmotionScRsp.Parser, new string[3] { "Retcode", "EmotionType", "ScriptId" }, null, null, null, null)
		}));
	}
}
