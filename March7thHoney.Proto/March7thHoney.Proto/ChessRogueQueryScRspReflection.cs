using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueQueryScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueQueryScRspReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "ChpDaGVzc1JvZ3VlUXVlcnlTY1JzcC5wcm90bxoRQkFCQUdFRENDQkcucHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "dG8aEUZJSUxQSEtMRkVLLnByb3RvGhFJTEVKR0VEQkVLRi5wcm90bxoRUERB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "TUJDRkZQREkucHJvdG8itgEKFENoZXNzUm9ndWVRdWVyeVNjUnNwEiQKDnJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "Z3VlX2dldF9pbmZvGAIgASgLMgwuQkFCQUdFRENDQkcSDwoHcmV0Y29kZRgD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "IAEoDRIhCgtORE1MRUdMSU9HThgFIAEoCzIMLkZJSUxQSEtMRkVLEiEKC09D";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "TExBREJGS0hQGAYgASgLMgwuUERBTUJDRkZQREkSIQoLTEpNRkdERkJMQ0sY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "ByABKAsyDC5JTEVKR0VEQkVLRkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[4]
		{
			BABAGEDCCBGReflection.Descriptor,
			FIILPHKLFEKReflection.Descriptor,
			ILEJGEDBEKFReflection.Descriptor,
			PDAMBCFFPDIReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueQueryScRsp), ChessRogueQueryScRsp.Parser, new string[5] { "RogueGetInfo", "Retcode", "NDMLEGLIOGN", "OCLLADBFKHP", "LJMFGDFBLCK" }, null, null, null, null)
		}));
	}
}
