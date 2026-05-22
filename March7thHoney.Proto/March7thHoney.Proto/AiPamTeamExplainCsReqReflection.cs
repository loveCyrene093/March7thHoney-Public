using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AiPamTeamExplainCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AiPamTeamExplainCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChtBaVBhbVRlYW1FeHBsYWluQ3NSZXEucHJvdG8aFU1lc3NhZ2VDaGF0RGF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "YS5wcm90byKUAQoVQWlQYW1UZWFtRXhwbGFpbkNzUmVxEhMKC0JIRkJJR0ZF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "REhMGAQgASgIEicKDW1lc3NhZ2VfZGF0YXMYBSABKAsyEC5NZXNzYWdlQ2hh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "dERhdGESEwoLRUxCREpOTE1FRk4YCSABKAgSEwoLTk1MSU1KSkhPUEsYCyAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "KAkSEwoLTExMQ0pOSkhFUEUYDSABKAhCFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { MessageChatDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AiPamTeamExplainCsReq), AiPamTeamExplainCsReq.Parser, new string[5] { "BHFBIGFEDHL", "MessageDatas", "ELBDJNLMEFN", "NMLIMJJHOPK", "LLLCJNJHEPE" }, null, null, null, null)
		}));
	}
}
