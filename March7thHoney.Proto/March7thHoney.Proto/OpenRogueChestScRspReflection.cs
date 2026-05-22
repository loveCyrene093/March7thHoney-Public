using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OpenRogueChestScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OpenRogueChestScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChlPcGVuUm9ndWVDaGVzdFNjUnNwLnByb3RvGg5JdGVtTGlzdC5wcm90bxoR";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "Tk5PSUpKTkNISkIucHJvdG8iggEKE09wZW5Sb2d1ZUNoZXN0U2NSc3ASDwoH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "cmV0Y29kZRgBIAEoDRIZCgZyZXdhcmQYAiABKAsyCS5JdGVtTGlzdBIcCglk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "cm9wX2RhdGEYByABKAsyCS5JdGVtTGlzdBIhCgtISUNORkpER0dHTBgMIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "CzIMLk5OT0lKSk5DSEpCQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			ItemListReflection.Descriptor,
			NNOIJJNCHJBReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OpenRogueChestScRsp), OpenRogueChestScRsp.Parser, new string[4] { "Retcode", "Reward", "DropData", "HICNFJDGGGL" }, null, null, null, null)
		}));
	}
}
