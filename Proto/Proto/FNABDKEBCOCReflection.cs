using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FNABDKEBCOCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FNABDKEBCOCReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFGTkFCREtFQkNPQy5wcm90bxoRRUtPSUhPTUZNREUucHJvdG8ipwEKC0ZO";
		buffer[1] = "QUJES0VCQ09DEiEKC0NMS0FJTERDUEpDGAIgAygLMgwuRUtPSUhPTUZNREUS";
		buffer[2] = "EwoLT09QQ0hJSElJRkUYBCABKA0SEwoLQUxDQkhKRU1DUEMYBSABKA0SEwoL";
		buffer[3] = "T0RISktMS0lDRkwYBiABKA0SIQoLSkhLTUxHSktJSU0YByABKAsyDC5FS09J";
		buffer[4] = "SE9NRk1ERRITCgtHRkREQlBBRUFPSRgPIAMoDUIWqgITTWFyY2g3dGhIb25l";
		buffer[5] = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { EKOIHOMFMDEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FNABDKEBCOC), FNABDKEBCOC.Parser, new string[6] { "CLKAILDCPJC", "OOPCHIHIIFE", "ALCBHJEMCPC", "ODHJKLKICFL", "JHKMLGJKIIM", "GFDDBPAEAOI" }, null, null, null, null)
		}));
	}
}
