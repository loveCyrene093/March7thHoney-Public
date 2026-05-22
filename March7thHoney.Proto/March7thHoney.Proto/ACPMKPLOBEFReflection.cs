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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChFBQ1BNS1BMT0JFRi5wcm90bxoRRE5BR1BNRUJCQ0sucHJvdG8aEUpBTUxI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "T0hCSUdCLnByb3RvGhFLTE1LTERPTkVKRy5wcm90byLKAQoLQUNQTUtQTE9C";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "RUYSEwoLSktMUE5PRkROQUwYAiABKAQSIQoLS0dLT0hOQUFDRU4YAyABKAsy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "DC5KQU1MSE9IQklHQhIhCgtETk5PRkdKSk1DUBgHIAMoCzIMLktMTUtMRE9O";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "RUpHEhMKC0FISUZIR05QR0JCGAggASgNEhMKC0xGQklFTEJIT0JLGAogASgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "EhMKC0xIS0REQkJJS09CGAsgASgFEiEKC0lQTEVPT0xDQUNJGA0gASgOMgwu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "RE5BR1BNRUJCQ0tCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[3]
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
