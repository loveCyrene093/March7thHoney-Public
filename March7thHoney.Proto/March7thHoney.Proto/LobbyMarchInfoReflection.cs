using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LobbyMarchInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LobbyMarchInfoReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChRMb2JieU1hcmNoSW5mby5wcm90bxoRR0ZOTUFLSFBBT0UucHJvdG8ihwEK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "DkxvYmJ5TWFyY2hJbmZvEhMKC05MT0NESE1MR0pIGAEgASgNEhMKC0dJS0FC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "RU1DRkFPGAIgASgIEhMKC0dKSUtCRkFIRUFLGAMgASgNEhMKC0ZCSlBKS0JE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "Q0xCGAQgASgNEiEKC09OSktCRU5OTUZDGAUgASgLMgwuR0ZOTUFLSFBBT0VC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { GFNMAKHPAOEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LobbyMarchInfo), LobbyMarchInfo.Parser, new string[5] { "NLOCDHMLGJH", "GIKABEMCFAO", "GJIKBFAHEAK", "FBJPJKBDCLB", "ONJKBENNMFC" }, null, null, null, null)
		}));
	}
}
