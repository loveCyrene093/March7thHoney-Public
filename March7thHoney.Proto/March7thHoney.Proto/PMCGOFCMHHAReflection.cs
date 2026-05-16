using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PMCGOFCMHHAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PMCGOFCMHHAReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFQTUNHT0ZDTUhIQS5wcm90bxoRS0tKTkZJUFBERE8ucHJvdG8imQEKC1BN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "Q0dPRkNNSEhBEhMKC0JGTEhNSURJRktGGAEgASgNEhMKC01NT0pPRUNETUlM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "GAMgAygNEhMKC0hLQlBFSEJMSUFDGAQgASgNEhMKC0VQQUlOSEhOQkxPGAkg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "ASgNEhMKC0dJSk9BQURLRElOGA0gAygNEiEKC0lNS09KS0pBSE1NGA8gAygL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "MgwuS0tKTkZJUFBERE9CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { KKJNFIPPDDOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PMCGOFCMHHA), PMCGOFCMHHA.Parser, new string[6] { "BFLHMIDIFKF", "MMOJOECDMIL", "HKBPEHBLIAC", "EPAINHHNBLO", "GIJOAADKDIN", "IMKOJKJAHMM" }, null, null, null, null)
		}));
	}
}
