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
		buffer[0] = "ChpDaGVzc1JvZ3VlUXVlcnlTY1JzcC5wcm90bxoRQkFCQUdFRENDQkcucHJv";
		buffer[1] = "dG8aEUZJSUxQSEtMRkVLLnByb3RvGhFJTEVKR0VEQkVLRi5wcm90bxoRUERB";
		buffer[2] = "TUJDRkZQREkucHJvdG8itgEKFENoZXNzUm9ndWVRdWVyeVNjUnNwEiQKDnJv";
		buffer[3] = "Z3VlX2dldF9pbmZvGAIgASgLMgwuQkFCQUdFRENDQkcSDwoHcmV0Y29kZRgD";
		buffer[4] = "IAEoDRIhCgtORE1MRUdMSU9HThgFIAEoCzIMLkZJSUxQSEtMRkVLEiEKC09D";
		buffer[5] = "TExBREJGS0hQGAYgASgLMgwuUERBTUJDRkZQREkSIQoLTEpNRkdERkJMQ0sY";
		buffer[6] = "ByABKAsyDC5JTEVKR0VEQkVLRkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[7] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
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
