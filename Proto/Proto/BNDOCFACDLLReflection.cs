using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BNDOCFACDLLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BNDOCFACDLLReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFCTkRPQ0ZBQ0RMTC5wcm90bxoRQlBERkVPR0NBSUoucHJvdG8ihAEKC0JO";
		buffer[1] = "RE9DRkFDRExMEhgKEGNvbXBvc2VfcmVsaWNfaWQYASABKA0SEgoKcmVsaWNf";
		buffer[2] = "dHlwZRgCIAEoDRIhCgtKS05HRkRNT0NHQxgDIAEoCzIMLkJQREZFT0dDQUlK";
		buffer[3] = "EiQKDnN1Yl9hZmZpeF9saXN0GAQgAygLMgwuQlBERkVPR0NBSUpCFqoCE01h";
		buffer[4] = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { BPDFEOGCAIJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BNDOCFACDLL), BNDOCFACDLL.Parser, new string[4] { "ComposeRelicId", "RelicType", "JKNGFDMOCGC", "SubAffixList" }, null, null, null, null)
		}));
	}
}
