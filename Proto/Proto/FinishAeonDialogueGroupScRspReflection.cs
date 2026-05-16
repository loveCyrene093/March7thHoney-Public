using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishAeonDialogueGroupScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishAeonDialogueGroupScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiJGaW5pc2hBZW9uRGlhbG9ndWVHcm91cFNjUnNwLnByb3RvGhFDTkhOR0xF";
		buffer[1] = "RUJLUC5wcm90bxoOSXRlbUxpc3QucHJvdG8ibQocRmluaXNoQWVvbkRpYWxv";
		buffer[2] = "Z3VlR3JvdXBTY1JzcBIZCgZyZXdhcmQYAyABKAsyCS5JdGVtTGlzdBIPCgdy";
		buffer[3] = "ZXRjb2RlGAwgASgNEiEKC0lNUEJFTEpHREpIGA0gASgLMgwuQ05ITkdMRUVC";
		buffer[4] = "S1BCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			CNHNGLEEBKPReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishAeonDialogueGroupScRsp), FinishAeonDialogueGroupScRsp.Parser, new string[3] { "Reward", "Retcode", "IMPBELJGDJH" }, null, null, null, null)
		}));
	}
}
