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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChtTd2l0Y2hIYW5kVXBkYXRlQ3NSZXEucHJvdG8aEUdPREhERUlQREpMLnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "b3RvGhFIS0xLR0pDSkpFQi5wcm90byJdChVTd2l0Y2hIYW5kVXBkYXRlQ3NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "ZXESIQoLSEtBRUVNQUJKTEEYBSABKAsyDC5HT0RIREVJUERKTBIhCgtDTlBJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "TEdOQkROQhgIIAEoCzIMLkhLTEtHSkNKSkVCQhaqAhNNYXJjaDd0aEhvbmV5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			GODHDEIPDJLReflection.Descriptor,
			HKLKGJCJJEBReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwitchHandUpdateCsReq), SwitchHandUpdateCsReq.Parser, new string[2] { "HKAEEMABJLA", "CNPILGNBDNB" }, null, null, null, null)
		}));
	}
}
