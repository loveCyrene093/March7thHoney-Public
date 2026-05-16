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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiJGaW5pc2hBZW9uRGlhbG9ndWVHcm91cFNjUnNwLnByb3RvGhFDTkhOR0xF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "RUJLUC5wcm90bxoOSXRlbUxpc3QucHJvdG8ibQocRmluaXNoQWVvbkRpYWxv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "Z3VlR3JvdXBTY1JzcBIZCgZyZXdhcmQYAyABKAsyCS5JdGVtTGlzdBIPCgdy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "ZXRjb2RlGAwgASgNEiEKC0lNUEJFTEpHREpIGA0gASgLMgwuQ05ITkdMRUVC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "S1BCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			CNHNGLEEBKPReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishAeonDialogueGroupScRsp), FinishAeonDialogueGroupScRsp.Parser, new string[3] { "Reward", "Retcode", "IMPBELJGDJH" }, null, null, null, null)
		}));
	}
}
