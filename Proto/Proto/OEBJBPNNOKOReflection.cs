using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OEBJBPNNOKOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OEBJBPNNOKOReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFPRUJKQlBOTk9LTy5wcm90bxoRTUFDSkJJQUZOT0kucHJvdG8aFlBsYXll";
		buffer[1] = "clNpbXBsZUluZm8ucHJvdG8iqAEKC09FQkpCUE5OT0tPEiEKC0lBQ0tPQ1BH";
		buffer[2] = "SUFLGAQgASgLMgwuTUFDSkJJQUZOT0kSFwoPc3VtbW9uZWRfcGV0X2lkGAYg";
		buffer[3] = "ASgNEgsKA3VpZBgIIAEoDRImCgtDR0xNSEpGQ0ZQSBgLIAEoCzIRLlBsYXll";
		buffer[4] = "clNpbXBsZUluZm8SEwoLRUtPRElGSk9CRkIYDCABKAMSEwoLSENKTUxNSUdB";
		buffer[5] = "Q0cYDSABKAhCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			MACJBIAFNOIReflection.Descriptor,
			PlayerSimpleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OEBJBPNNOKO), OEBJBPNNOKO.Parser, new string[6] { "IACKOCPGIAK", "SummonedPetId", "Uid", "CGLMHJFCFPH", "EKODIFJOBFB", "HCJMLMIGACG" }, null, null, null, null)
		}));
	}
}
