using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishEmotionDialoguePerformanceScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishEmotionDialoguePerformanceScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CitGaW5pc2hFbW90aW9uRGlhbG9ndWVQZXJmb3JtYW5jZVNjUnNwLnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "Gg5JdGVtTGlzdC5wcm90byKAAQolRmluaXNoRW1vdGlvbkRpYWxvZ3VlUGVy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "Zm9ybWFuY2VTY1JzcBIRCglzY3JpcHRfaWQYBiABKA0SDwoHcmV0Y29kZRgH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "IAEoDRITCgtkaWFsb2d1ZV9pZBgJIAEoDRIeCgtyZXdhcmRfbGlzdBgNIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "CzIJLkl0ZW1MaXN0QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishEmotionDialoguePerformanceScRsp), FinishEmotionDialoguePerformanceScRsp.Parser, new string[4] { "ScriptId", "Retcode", "DialogueId", "RewardList" }, null, null, null, null)
		}));
	}
}
