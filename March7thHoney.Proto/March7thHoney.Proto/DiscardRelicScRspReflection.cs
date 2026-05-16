using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DiscardRelicScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DiscardRelicScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChdEaXNjYXJkUmVsaWNTY1JzcC5wcm90bxoWUmVsaWNEaXNjYXJkVHlwZS5w";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "cm90byJyChFEaXNjYXJkUmVsaWNTY1JzcBIPCgdyZXRjb2RlGAIgASgNEhEK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "CXJlbGljX2lkcxgJIAMoDRIRCglEaXNjYXJkZWQYDCABKAgSJgoLSEhITE1O";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "TE1BR0MYDiABKA4yES5SZWxpY0Rpc2NhcmRUeXBlQhaqAhNNYXJjaDd0aEhv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { RelicDiscardTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DiscardRelicScRsp), DiscardRelicScRsp.Parser, new string[4] { "Retcode", "RelicIds", "Discarded", "HHHLMNLMAGC" }, null, null, null, null)
		}));
	}
}
