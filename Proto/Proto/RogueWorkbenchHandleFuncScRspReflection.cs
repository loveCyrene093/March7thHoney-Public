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
		buffer[0] = "CiNSb2d1ZVdvcmtiZW5jaEhhbmRsZUZ1bmNTY1JzcC5wcm90bxoRQ0dLQkVC";
		buffer[1] = "Q0NER0YucHJvdG8iZAodUm9ndWVXb3JrYmVuY2hIYW5kbGVGdW5jU2NSc3AS";
		buffer[2] = "DwoHcmV0Y29kZRgBIAEoDRIPCgdmdW5jX2lkGAMgASgNEiEKC0FDQURLUEpL";
		buffer[3] = "QURFGAsgASgLMgwuQ0dLQkVCQ0NER0ZCFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		buffer[4] = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { CGKBEBCCDGFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueWorkbenchHandleFuncScRsp), RogueWorkbenchHandleFuncScRsp.Parser, new string[3] { "Retcode", "FuncId", "ACADKPJKADE" }, null, null, null, null)
		}));
	}
}
