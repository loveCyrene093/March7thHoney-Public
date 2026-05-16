using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CJPFNAFLAPDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CJPFNAFLAPDReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFDSlBGTkFGTEFQRC5wcm90bxoRSElHR01MRUZKTkkucHJvdG8aEUtEQkxL";
		buffer[1] = "T0dLSEVFLnByb3RvInwKC0NKUEZOQUZMQVBEEhQKC0JDSk1PRU1ER0pLGJsD";
		buffer[2] = "IAEoDRIjCgtETERESktCTkxJTRgLIAEoCzIMLktEQkxLT0dLSEVFSAASIwoL";
		buffer[3] = "TkhOSExOTUpLTEEYDCABKAsyDC5ISUdHTUxFRkpOSUgAQg0KC0JQSUhGQUpD";
		buffer[4] = "TE9DQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			HIGGMLEFJNIReflection.Descriptor,
			KDBLKOGKHEEReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CJPFNAFLAPD), CJPFNAFLAPD.Parser, new string[3] { "BCJMOEMDGJK", "DLDDJKBNLIM", "NHNHLNMJKLA" }, new string[1] { "BPIHFAJCLOC" }, null, null, null)
		}));
	}
}
