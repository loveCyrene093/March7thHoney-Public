using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ACPMKPLOBEFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ACPMKPLOBEFReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFBQ1BNS1BMT0JFRi5wcm90bxoRRE5BR1BNRUJCQ0sucHJvdG8aEUpBTUxI";
		buffer[1] = "T0hCSUdCLnByb3RvGhFLTE1LTERPTkVKRy5wcm90byLKAQoLQUNQTUtQTE9C";
		buffer[2] = "RUYSEwoLSktMUE5PRkROQUwYAiABKAQSIQoLS0dLT0hOQUFDRU4YAyABKAsy";
		buffer[3] = "DC5KQU1MSE9IQklHQhIhCgtETk5PRkdKSk1DUBgHIAMoCzIMLktMTUtMRE9O";
		buffer[4] = "RUpHEhMKC0FISUZIR05QR0JCGAggASgNEhMKC0xGQklFTEJIT0JLGAogASgN";
		buffer[5] = "EhMKC0xIS0REQkJJS09CGAsgASgFEiEKC0lQTEVPT0xDQUNJGA0gASgOMgwu";
		buffer[6] = "RE5BR1BNRUJCQ0tCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			DNAGPMEBBCKReflection.Descriptor,
			JAMLHOHBIGBReflection.Descriptor,
			KLMKLDONEJGReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ACPMKPLOBEF), ACPMKPLOBEF.Parser, new string[7] { "JKLPNOFDNAL", "KGKOHNAACEN", "DNNOFGJJMCP", "AHIFHGNPGBB", "LFBIELBHOBK", "LHKDDBBIKOB", "IPLEOOLCACI" }, null, null, null, null)
		}));
	}
}
