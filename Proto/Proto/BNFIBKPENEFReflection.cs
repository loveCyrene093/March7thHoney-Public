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
		buffer[0] = "ChFCTkZJQktQRU5FRi5wcm90bxoRS0JPSkFDQUVBREwucHJvdG8iggEKC0JO";
		buffer[1] = "RklCS1BFTkVGEhMKC0JPRUZDQ1BCQ0REGAQgASgNEhMKC0xPSUpMSUtPTUpO";
		buffer[2] = "GA8gASgNEhUKC0xPTE9FRk9CT0tBGAIgASgNSAASIwoLTkFOSEZLRUpNQ0oY";
		buffer[3] = "CyABKAsyDC5LQk9KQUNBRUFETEgAQg0KC0NKRkJFT05KSURMQhaqAhNNYXJj";
		buffer[4] = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { KBOJACAEADLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BNFIBKPENEF), BNFIBKPENEF.Parser, new string[4] { "BOEFCCPBCDD", "LOIJLIKOMJN", "LOLOEFOBOKA", "NANHFKEJMCJ" }, new string[1] { "CJFBEONJIDL" }, null, null, null)
		}));
	}
}
