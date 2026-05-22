using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetSwitchHandUpdateScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetSwitchHandUpdateScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Ch5HZXRTd2l0Y2hIYW5kVXBkYXRlU2NSc3AucHJvdG8aEUdPREhERUlQREpM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "LnByb3RvGhFIS0xLR0pDSkpFQi5wcm90byJxChhHZXRTd2l0Y2hIYW5kVXBk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "YXRlU2NSc3ASIQoLT01IQUVOQklLQ04YBSABKAsyDC5HT0RIREVJUERKTBIP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "CgdyZXRjb2RlGAggASgNEiEKC0NOUElMR05CRE5CGA4gASgLMgwuSEtMS0dK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "Q0pKRUJCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			GODHDEIPDJLReflection.Descriptor,
			HKLKGJCJJEBReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetSwitchHandUpdateScRsp), GetSwitchHandUpdateScRsp.Parser, new string[3] { "OMHAENBIKCN", "Retcode", "CNPILGNBDNB" }, null, null, null, null)
		}));
	}
}
