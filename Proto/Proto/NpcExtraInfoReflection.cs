using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NpcExtraInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NpcExtraInfoReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChJOcGNFeHRyYUluZm8ucHJvdG8aEUVCRkJQSElBRE1JLnByb3RvGhFORUFP";
		buffer[1] = "QkZKT01DRi5wcm90bxoWTnBjUm9ndWVHYW1lSW5mby5wcm90byKVAQoMTnBj";
		buffer[2] = "RXh0cmFJbmZvEiMKC0pBQ0RBRENITkZMGAMgASgLMgwuRUJGQlBISUFETUlI";
		buffer[3] = "ABIjCgtGUENPTU5BT0FCRBgLIAEoCzIMLk5FQU9CRkpPTUNGSAASLAoPcm9n";
		buffer[4] = "dWVfZ2FtZV9pbmZvGA8gASgLMhEuTnBjUm9ndWVHYW1lSW5mb0gAQg0KC0JQ";
		buffer[5] = "SUhGQUpDTE9DQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			EBFBPHIADMIReflection.Descriptor,
			NEAOBFJOMCFReflection.Descriptor,
			NpcRogueGameInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NpcExtraInfo), NpcExtraInfo.Parser, new string[3] { "JACDADCHNFL", "FPCOMNAOABD", "RogueGameInfo" }, new string[1] { "BPIHFAJCLOC" }, null, null, null)
		}));
	}
}
