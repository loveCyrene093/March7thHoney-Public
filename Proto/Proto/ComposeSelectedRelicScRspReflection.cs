using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ComposeSelectedRelicScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ComposeSelectedRelicScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch9Db21wb3NlU2VsZWN0ZWRSZWxpY1NjUnNwLnByb3RvGg5JdGVtTGlzdC5w";
		buffer[1] = "cm90byJlChlDb21wb3NlU2VsZWN0ZWRSZWxpY1NjUnNwEhIKCmNvbXBvc2Vf";
		buffer[2] = "aWQYAiABKA0SDwoHcmV0Y29kZRgIIAEoDRIjChByZXR1cm5faXRlbV9saXN0";
		buffer[3] = "GAogASgLMgkuSXRlbUxpc3RCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		buffer[4] = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ComposeSelectedRelicScRsp), ComposeSelectedRelicScRsp.Parser, new string[3] { "ComposeId", "Retcode", "ReturnItemList" }, null, null, null, null)
		}));
	}
}
