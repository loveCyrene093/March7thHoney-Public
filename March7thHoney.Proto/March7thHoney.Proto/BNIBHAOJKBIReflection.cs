using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BNIBHAOJKBIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BNIBHAOJKBIReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFCTklCSEFPSktCSS5wcm90bxoRREZBT0lBTEVCT0gucHJvdG8aDkl0ZW1M";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "aXN0LnByb3RvImEKC0JOSUJIQU9KS0JJEh4KC0RBTE5KRkJHSEhQGAEgASgL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "MgkuSXRlbUxpc3QSDwoHcmV0Y29kZRgJIAEoDRIhCgtQSkFCS0RCRlBJTRgK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "IAEoCzIMLkRGQU9JQUxFQk9IQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			DFAOIALEBOHReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BNIBHAOJKBI), BNIBHAOJKBI.Parser, new string[3] { "DALNJFBGHHP", "Retcode", "PJABKDBFPIM" }, null, null, null, null)
		}));
	}
}
