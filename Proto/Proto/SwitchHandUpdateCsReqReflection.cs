using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwitchHandUpdateCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwitchHandUpdateCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChtTd2l0Y2hIYW5kVXBkYXRlQ3NSZXEucHJvdG8aEUdPREhERUlQREpMLnBy";
		buffer[1] = "b3RvGhFIS0xLR0pDSkpFQi5wcm90byJdChVTd2l0Y2hIYW5kVXBkYXRlQ3NS";
		buffer[2] = "ZXESIQoLSEtBRUVNQUJKTEEYBSABKAsyDC5HT0RIREVJUERKTBIhCgtDTlBJ";
		buffer[3] = "TEdOQkROQhgIIAEoCzIMLkhLTEtHSkNKSkVCQhaqAhNNYXJjaDd0aEhvbmV5";
		buffer[4] = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			GODHDEIPDJLReflection.Descriptor,
			HKLKGJCJJEBReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwitchHandUpdateCsReq), SwitchHandUpdateCsReq.Parser, new string[2] { "HKAEEMABJLA", "CNPILGNBDNB" }, null, null, null, null)
		}));
	}
}
