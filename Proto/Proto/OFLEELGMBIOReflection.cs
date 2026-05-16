using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OFLEELGMBIOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OFLEELGMBIOReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFPRkxFRUxHTUJJTy5wcm90bxoRS0ZLRElFQUpQQ0oucHJvdG8igAEKC09G";
		buffer[1] = "TEVFTEdNQklPEhYKC0dOREpQTkJFQ0pQGMECIAEoCEgAEiQKC0NERExKT0pB";
		buffer[2] = "SE9BGJcKIAEoCzIMLktGS0RJRUFKUENKSAASJAoLTkhLSEtLRkJERU4Y3Asg";
		buffer[3] = "ASgLMgwuS0ZLRElFQUpQQ0pIAEINCgtCSEtQQU1ERkdBQUIWqgITTWFyY2g3";
		buffer[4] = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { KFKDIEAJPCJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OFLEELGMBIO), OFLEELGMBIO.Parser, new string[3] { "GNDJPNBECJP", "CDDLJOJAHOA", "NHKHKKFBDEN" }, new string[1] { "BHKPAMDFGAA" }, null, null, null)
		}));
	}
}
