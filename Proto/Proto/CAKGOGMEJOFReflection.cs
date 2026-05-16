using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CAKGOGMEJOFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CAKGOGMEJOFReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChFDQUtHT0dNRUpPRi5wcm90bxoRQ0JFTERFQ0RDQ0kucHJvdG8aEVBNTkdK";
		buffer[1] = "Q0RDR01NLnByb3RvIugBCgtDQUtHT0dNRUpPRhIjCg1tZXNzYWdlX2RhdGFz";
		buffer[2] = "GAEgAygLMgwuUE1OR0pDRENHTU0SMgoLQkxNUE5PTlBMTkkYAiADKAsyHS5D";
		buffer[3] = "QUtHT0dNRUpPRi5CTE1QTk9OUExOSUVudHJ5EiEKC09NQkxQT0NIQ0hNGAMg";
		buffer[4] = "AygLMgwuQ0JFTERFQ0RDQ0kSDwoHYXJlYV9pZBgEIAEoDRIYChBkaWZmaWN1";
		buffer[5] = "bHR5X2xldmVsGAUgASgNGjIKEEJMTVBOT05QTE5JRW50cnkSCwoDa2V5GAEg";
		buffer[6] = "ASgNEg0KBXZhbHVlGAIgASgNOgI4AUIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		buffer[7] = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			CBELDECDCCIReflection.Descriptor,
			PMNGJCDCGMMReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CAKGOGMEJOF), CAKGOGMEJOF.Parser, new string[5] { "MessageDatas", "BLMPNONPLNI", "OMBLPOCHCHM", "AreaId", "DifficultyLevel" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
