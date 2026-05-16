using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ExchangeGachaCeilingReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ExchangeGachaCeilingReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChpFeGNoYW5nZUdhY2hhQ2VpbGluZy5wcm90bxoSR2FjaGFDZWlsaW5nLnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "b3RvGg5JdGVtTGlzdC5wcm90byKbAQoURXhjaGFuZ2VHYWNoYUNlaWxpbmcS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "DwoHcmV0Y29kZRgCIAEoDRIlChJ0cmFuc2Zlcl9pdGVtX2xpc3QYAyABKAsy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "CS5JdGVtTGlzdBIkCg1nYWNoYV9jZWlsaW5nGAYgASgLMg0uR2FjaGFDZWls";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "aW5nEhIKCmdhY2hhX3R5cGUYCCABKA0SEQoJYXZhdGFyX2lkGAkgASgNQhaq";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			GachaCeilingReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ExchangeGachaCeiling), ExchangeGachaCeiling.Parser, new string[5] { "Retcode", "TransferItemList", "GachaCeiling", "GachaType", "AvatarId" }, null, null, null, null)
		}));
	}
}
