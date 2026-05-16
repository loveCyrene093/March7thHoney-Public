using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetPlayerReturnMultiDropInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetPlayerReturnMultiDropInfoScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CidHZXRQbGF5ZXJSZXR1cm5NdWx0aURyb3BJbmZvU2NSc3AucHJvdG8aEUFF";
		buffer[1] = "T0VGT0lMRUJQLnByb3RvGhFFTkFMT0tJRkRGSC5wcm90byJ6CiFHZXRQbGF5";
		buffer[2] = "ZXJSZXR1cm5NdWx0aURyb3BJbmZvU2NSc3ASDwoHcmV0Y29kZRgEIAEoDRIh";
		buffer[3] = "CgtKTkdIR0xNQlBPSBgNIAMoCzIMLkFFT0VGT0lMRUJQEiEKC0JNQUdHQkNN";
		buffer[4] = "RExCGA8gASgLMgwuRU5BTE9LSUZERkhCFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		buffer[5] = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			AEOEFOILEBPReflection.Descriptor,
			ENALOKIFDFHReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetPlayerReturnMultiDropInfoScRsp), GetPlayerReturnMultiDropInfoScRsp.Parser, new string[3] { "Retcode", "JNGHGLMBPOH", "BMAGGBCMDLB" }, null, null, null, null)
		}));
	}
}
