using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMultipleDropInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMultipleDropInfoScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Ch5HZXRNdWx0aXBsZURyb3BJbmZvU2NSc3AucHJvdG8aEUFFT0VGT0lMRUJQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "LnByb3RvGhFETUlOTExETk5ETC5wcm90byJxChhHZXRNdWx0aXBsZURyb3BJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "bmZvU2NSc3ASIQoLSk5HSEdMTUJQT0gYAiADKAsyDC5BRU9FRk9JTEVCUBIP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "CgdyZXRjb2RlGAMgASgNEiEKC0RGRU9PRUhGQUFDGAQgAygLMgwuRE1JTkxM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "RE5ORExCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			AEOEFOILEBPReflection.Descriptor,
			DMINLLDNNDLReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMultipleDropInfoScRsp), GetMultipleDropInfoScRsp.Parser, new string[3] { "JNGHGLMBPOH", "Retcode", "DFEOOEHFAAC" }, null, null, null, null)
		}));
	}
}
