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
		buffer[0] = "ChFQTUNHT0ZDTUhIQS5wcm90bxoRS0tKTkZJUFBERE8ucHJvdG8imQEKC1BN";
		buffer[1] = "Q0dPRkNNSEhBEhMKC0JGTEhNSURJRktGGAEgASgNEhMKC01NT0pPRUNETUlM";
		buffer[2] = "GAMgAygNEhMKC0hLQlBFSEJMSUFDGAQgASgNEhMKC0VQQUlOSEhOQkxPGAkg";
		buffer[3] = "ASgNEhMKC0dJSk9BQURLRElOGA0gAygNEiEKC0lNS09KS0pBSE1NGA8gAygL";
		buffer[4] = "MgwuS0tKTkZJUFBERE9CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[5] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { KKJNFIPPDDOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PMCGOFCMHHA), PMCGOFCMHHA.Parser, new string[6] { "BFLHMIDIFKF", "MMOJOECDMIL", "HKBPEHBLIAC", "EPAINHHNBLO", "GIJOAADKDIN", "IMKOJKJAHMM" }, null, null, null, null)
		}));
	}
}
