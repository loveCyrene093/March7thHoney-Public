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
		buffer[0] = "ChFCTklCSEFPSktCSS5wcm90bxoRREZBT0lBTEVCT0gucHJvdG8aDkl0ZW1M";
		buffer[1] = "aXN0LnByb3RvImEKC0JOSUJIQU9KS0JJEh4KC0RBTE5KRkJHSEhQGAEgASgL";
		buffer[2] = "MgkuSXRlbUxpc3QSDwoHcmV0Y29kZRgJIAEoDRIhCgtQSkFCS0RCRlBJTRgK";
		buffer[3] = "IAEoCzIMLkRGQU9JQUxFQk9IQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		buffer[4] = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			DFAOIALEBOHReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BNIBHAOJKBI), BNIBHAOJKBI.Parser, new string[3] { "DALNJFBGHHP", "Retcode", "PJABKDBFPIM" }, null, null, null, null)
		}));
	}
}
