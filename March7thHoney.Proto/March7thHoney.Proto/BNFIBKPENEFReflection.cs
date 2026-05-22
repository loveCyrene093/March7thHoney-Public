using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BNFIBKPENEFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BNFIBKPENEFReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFCTkZJQktQRU5FRi5wcm90bxoRS0JPSkFDQUVBREwucHJvdG8iggEKC0JO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "RklCS1BFTkVGEhMKC0JPRUZDQ1BCQ0REGAQgASgNEhMKC0xPSUpMSUtPTUpO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "GA8gASgNEhUKC0xPTE9FRk9CT0tBGAIgASgNSAASIwoLTkFOSEZLRUpNQ0oY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "CyABKAsyDC5LQk9KQUNBRUFETEgAQg0KC0NKRkJFT05KSURMQhaqAhNNYXJj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { KBOJACAEADLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BNFIBKPENEF), BNFIBKPENEF.Parser, new string[4] { "BOEFCCPBCDD", "LOIJLIKOMJN", "LOLOEFOBOKA", "NANHFKEJMCJ" }, new string[1] { "CJFBEONJIDL" }, null, null, null)
		}));
	}
}
