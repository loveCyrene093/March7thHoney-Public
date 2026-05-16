using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HLEIOFJEAKCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HLEIOFJEAKCReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFITEVJT0ZKRUFLQy5wcm90bxoRRERGQUZHTUxMRkQucHJvdG8aEU5FRlBB";
		buffer[1] = "S0hGSUhCLnByb3RvIrwBCgtITEVJT0ZKRUFLQxIhCgtIRUdOSE5GTklPTxgB";
		buffer[2] = "IAMoCzIMLk5FRlBBS0hGSUhCEhMKC0lJRkxCSk5NTkJPGAUgASgNEiEKC0hL";
		buffer[3] = "Q0VKQ05JTEZEGAYgAygLMgwuRERGQUZHTUxMRkQSEwoLRE5KRUVPRU5NQUEY";
		buffer[4] = "CCABKAQSEwoLS0hPSURESE5OR08YCiADKA0SEwoLQ1BGT0NMQ0ZGSkYYDSAB";
		buffer[5] = "KA0SEwoLQVBERkxMTEpBQkIYDiADKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		buffer[6] = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			DDFAFGMLLFDReflection.Descriptor,
			NEFPAKHFIHBReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HLEIOFJEAKC), HLEIOFJEAKC.Parser, new string[7] { "HEGNHNFNIOO", "IIFLBJNMNBO", "HKCEJCNILFD", "DNJEEOENMAA", "KHOIDDHNNGO", "CPFOCLCFFJF", "APDFLLLJABB" }, null, null, null, null)
		}));
	}
}
