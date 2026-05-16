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
		buffer[0] = "ChFFRkJJSEpITUlDQi5wcm90bxoRQkpLQUtHQk9OQk0ucHJvdG8aEUdNR0pB";
		buffer[1] = "TEhPR09HLnByb3RvGhFQTEdPTUlNTk5BRS5wcm90byKtAQoLRUZCSUhKSE1J";
		buffer[2] = "Q0ISCwoDdWlkGAIgASgNEhMKC0RCT0pDSEJBSENJGAogASgNEiMKC0ZFQ09C";
		buffer[3] = "Q0xBQU1BGAQgASgLMgwuUExHT01JTU5OQUVIABIjCgtDTUJQTUlIR0hBSxgF";
		buffer[4] = "IAEoCzIMLkdNR0pBTEhPR09HSAASIwoLTkJGSktET05NREYYDSABKAsyDC5C";
		buffer[5] = "SktBS0dCT05CTUgAQg0KC0JQSUhGQUpDTE9DQhaqAhNNYXJjaDd0aEhvbmV5";
		buffer[6] = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
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
