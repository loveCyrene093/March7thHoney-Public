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
		buffer[0] = "Ch5HZXRTd2l0Y2hIYW5kVXBkYXRlU2NSc3AucHJvdG8aEUdPREhERUlQREpM";
		buffer[1] = "LnByb3RvGhFIS0xLR0pDSkpFQi5wcm90byJxChhHZXRTd2l0Y2hIYW5kVXBk";
		buffer[2] = "YXRlU2NSc3ASIQoLT01IQUVOQklLQ04YBSABKAsyDC5HT0RIREVJUERKTBIP";
		buffer[3] = "CgdyZXRjb2RlGAggASgNEiEKC0NOUElMR05CRE5CGA4gASgLMgwuSEtMS0dK";
		buffer[4] = "Q0pKRUJCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			GODHDEIPDJLReflection.Descriptor,
			HKLKGJCJJEBReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetSwitchHandUpdateScRsp), GetSwitchHandUpdateScRsp.Parser, new string[3] { "OMHAENBIKCN", "Retcode", "CNPILGNBDNB" }, null, null, null, null)
		}));
	}
}
