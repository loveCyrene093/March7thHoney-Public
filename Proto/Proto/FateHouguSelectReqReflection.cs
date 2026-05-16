using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FateHouguSelectReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FateHouguSelectReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChhGYXRlSG91Z3VTZWxlY3RSZXEucHJvdG8aEURPSkFDTkJDRUVILnByb3Rv";
		buffer[1] = "GhFLT1BORlBQSUZDSS5wcm90byKFAQoSRmF0ZUhvdWd1U2VsZWN0UmVxEhYK";
		buffer[2] = "DnF1ZXVlX3Bvc2l0aW9uGAwgASgNEiMKC0NJQ0dNTkhNTE1FGAYgASgLMgwu";
		buffer[3] = "RE9KQUNOQkNFRUhIABIjCgtDT0hNR0dQSElIThgJIAEoCzIMLktPUE5GUFBJ";
		buffer[4] = "RkNJSABCDQoLSUhOTUhOUE1ISkdCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		buffer[5] = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			DOJACNBCEEHReflection.Descriptor,
			KOPNFPPIFCIReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FateHouguSelectReq), FateHouguSelectReq.Parser, new string[3] { "QueuePosition", "CICGMNHMLME", "COHMGGPHIHN" }, new string[1] { "IHNMHNPMHJG" }, null, null, null)
		}));
	}
}
