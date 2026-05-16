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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChJOcGNFeHRyYUluZm8ucHJvdG8aEUVCRkJQSElBRE1JLnByb3RvGhFORUFP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "QkZKT01DRi5wcm90bxoWTnBjUm9ndWVHYW1lSW5mby5wcm90byKVAQoMTnBj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "RXh0cmFJbmZvEiMKC0pBQ0RBRENITkZMGAMgASgLMgwuRUJGQlBISUFETUlI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "ABIjCgtGUENPTU5BT0FCRBgLIAEoCzIMLk5FQU9CRkpPTUNGSAASLAoPcm9n";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "dWVfZ2FtZV9pbmZvGA8gASgLMhEuTnBjUm9ndWVHYW1lSW5mb0gAQg0KC0JQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "SUhGQUpDTE9DQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[3]
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
