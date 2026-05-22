using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueWorkbenchHandleFuncScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueWorkbenchHandleFuncScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiNSb2d1ZVdvcmtiZW5jaEhhbmRsZUZ1bmNTY1JzcC5wcm90bxoRQ0dLQkVC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "Q0NER0YucHJvdG8iZAodUm9ndWVXb3JrYmVuY2hIYW5kbGVGdW5jU2NSc3AS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "DwoHcmV0Y29kZRgBIAEoDRIPCgdmdW5jX2lkGAMgASgNEiEKC0FDQURLUEpL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "QURFGAsgASgLMgwuQ0dLQkVCQ0NER0ZCFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { CGKBEBCCDGFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueWorkbenchHandleFuncScRsp), RogueWorkbenchHandleFuncScRsp.Parser, new string[3] { "Retcode", "FuncId", "ACADKPJKADE" }, null, null, null, null)
		}));
	}
}
