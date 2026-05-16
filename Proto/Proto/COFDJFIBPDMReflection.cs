using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class COFDJFIBPDMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static COFDJFIBPDMReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFDT0ZESkZJQlBETS5wcm90bxoRQUtHTEFFS0NGTk8ucHJvdG8aEU1HTE1F";
		buffer[1] = "TVBKRUxELnByb3RvGhFOQkJFSEJOQUFGSS5wcm90byKLAQoLQ09GREpGSUJQ";
		buffer[2] = "RE0SIwoLQlBIQUVGQUpKS08YAyABKAsyDC5OQkJFSEJOQUFGSUgAEiMKC0dC";
		buffer[3] = "SEpHSUxJSk1QGA0gASgLMgwuTUdMTUVNUEpFTERIABIjCgtCUEZDRUpLTkNE";
		buffer[4] = "UBgOIAEoCzIMLkFLR0xBRUtDRk5PSABCDQoLQkdNREtMT0JJQ01CFqoCE01h";
		buffer[5] = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			AKGLAEKCFNOReflection.Descriptor,
			MGLMEMPJELDReflection.Descriptor,
			NBBEHBNAAFIReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(COFDJFIBPDM), COFDJFIBPDM.Parser, new string[3] { "BPHAEFAJJKO", "GBHJGILIJMP", "BPFCEJKNCDP" }, new string[1] { "BGMDKLOBICM" }, null, null, null)
		}));
	}
}
