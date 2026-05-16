using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CCNLHLLIAPLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CCNLHLLIAPLReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFDQ05MSExMSUFQTC5wcm90bxoRQ0pNTUtGSEpQSEoucHJvdG8aEURGQUpB";
		buffer[1] = "RU5LS0JQLnByb3RvIo0BCgtDQ05MSExMSUFQTBIQCgh0cmFpdF9pZBgDIAEo";
		buffer[2] = "DRIRCgllZmZlY3RfaWQYDCABKA0SJAoLRkxKTkRGTUdEQkkY1QYgASgLMgwu";
		buffer[3] = "REZBSkFFTktLQlBIABIkCgtIQUlOSktMTExLRhi7ByABKAsyDC5DSk1NS0ZI";
		buffer[4] = "SlBISkgAQg0KC0hEQUNDSUVJSkZPQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		buffer[5] = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			CJMMKFHJPHJReflection.Descriptor,
			DFAJAENKKBPReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CCNLHLLIAPL), CCNLHLLIAPL.Parser, new string[4] { "TraitId", "EffectId", "FLJNDFMGDBI", "HAINJKLLLKF" }, new string[1] { "HDACCIEIJFO" }, null, null, null)
		}));
	}
}
