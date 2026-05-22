using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EFBIHJHMICBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EFBIHJHMICBReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChFFRkJJSEpITUlDQi5wcm90bxoRQkpLQUtHQk9OQk0ucHJvdG8aEUdNR0pB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "TEhPR09HLnByb3RvGhFQTEdPTUlNTk5BRS5wcm90byKtAQoLRUZCSUhKSE1J";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "Q0ISCwoDdWlkGAIgASgNEhMKC0RCT0pDSEJBSENJGAogASgNEiMKC0ZFQ09C";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "Q0xBQU1BGAQgASgLMgwuUExHT01JTU5OQUVIABIjCgtDTUJQTUlIR0hBSxgF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "IAEoCzIMLkdNR0pBTEhPR09HSAASIwoLTkJGSktET05NREYYDSABKAsyDC5C";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "SktBS0dCT05CTUgAQg0KC0JQSUhGQUpDTE9DQhaqAhNNYXJjaDd0aEhvbmV5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[3]
		{
			BJKAKGBONBMReflection.Descriptor,
			GMGJALHOGOGReflection.Descriptor,
			PLGOMIMNNAEReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EFBIHJHMICB), EFBIHJHMICB.Parser, new string[5] { "Uid", "DBOJCHBAHCI", "FECOBCLAAMA", "CMBPMIHGHAK", "NBFJKDONMDF" }, new string[1] { "BPIHFAJCLOC" }, null, null, null)
		}));
	}
}
