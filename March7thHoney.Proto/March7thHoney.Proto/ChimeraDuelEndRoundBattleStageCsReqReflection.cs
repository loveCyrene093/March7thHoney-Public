using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraDuelEndRoundBattleStageCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraDuelEndRoundBattleStageCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CilDaGltZXJhRHVlbEVuZFJvdW5kQmF0dGxlU3RhZ2VDc1JlcS5wcm90bxoR";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "RENJRlBJQ1BKTUsucHJvdG8aEUhIQkVEUE1ITkRLLnByb3RvIngKI0NoaW1l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "cmFEdWVsRW5kUm91bmRCYXR0bGVTdGFnZUNzUmVxEiEKC0tHRUJKTkhPTENO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "GAcgASgOMgwuRENJRlBJQ1BKTUsSGQoDc3R0GAkgASgLMgwuSEhCRURQTUhO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "REsSEwoLTkFJTU9QT0hKS1AYDCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			DCIFPICPJMKReflection.Descriptor,
			HHBEDPMHNDKReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraDuelEndRoundBattleStageCsReq), ChimeraDuelEndRoundBattleStageCsReq.Parser, new string[3] { "KGEBJNHOLCN", "Stt", "NAIMOPOHJKP" }, null, null, null, null)
		}));
	}
}
