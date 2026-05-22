using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JMGAOIFBNEOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JMGAOIFBNEOReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFKTUdBT0lGQk5FTy5wcm90bxoRQURITkpBRElKQUMucHJvdG8aEUxHT1BM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "SUFGTENLLnByb3RvIl0KC0pNR0FPSUZCTkVPEiEKC0JJRUJGSEVDRVBNGAIg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "AygLMgwuQURITkpBRElKQUMSDwoHcmV0Y29kZRgMIAEoDRIaCgRkYXRhGA0g";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "ASgLMgwuTEdPUExJQUZMQ0tCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			ADHNJADIJACReflection.Descriptor,
			LGOPLIAFLCKReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JMGAOIFBNEO), JMGAOIFBNEO.Parser, new string[3] { "BIEBFHECEPM", "Retcode", "Data" }, null, null, null, null)
		}));
	}
}
