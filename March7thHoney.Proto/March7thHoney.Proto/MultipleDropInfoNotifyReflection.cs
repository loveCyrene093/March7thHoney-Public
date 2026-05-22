using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MultipleDropInfoNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MultipleDropInfoNotifyReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChxNdWx0aXBsZURyb3BJbmZvTm90aWZ5LnByb3RvGhFBRU9FRk9JTEVCUC5w";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "cm90bxoRRE1JTkxMRE5OREwucHJvdG8aEUVOQUxPS0lGREZILnByb3RvIoEB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "ChZNdWx0aXBsZURyb3BJbmZvTm90aWZ5EiEKC0RGRU9PRUhGQUFDGAEgAygL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "MgwuRE1JTkxMRE5OREwSIQoLQUxES0xLSExHR1AYBSADKAsyDC5FTkFMT0tJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "RkRGSBIhCgtKTkdIR0xNQlBPSBgOIAMoCzIMLkFFT0VGT0lMRUJQQhaqAhNN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[3]
		{
			AEOEFOILEBPReflection.Descriptor,
			DMINLLDNNDLReflection.Descriptor,
			ENALOKIFDFHReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MultipleDropInfoNotify), MultipleDropInfoNotify.Parser, new string[3] { "DFEOOEHFAAC", "ALDKLKHLGGP", "JNGHGLMBPOH" }, null, null, null, null)
		}));
	}
}
