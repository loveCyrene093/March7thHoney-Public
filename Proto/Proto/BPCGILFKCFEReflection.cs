using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BPCGILFKCFEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BPCGILFKCFEReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "ChFCUENHSUxGS0NGRS5wcm90bxoVQmF0dGxlRW5kU3RhdHVzLnByb3RvGhZC";
		buffer[1] = "YXR0bGVTdGF0aXN0aWNzLnByb3RvGhFMT1BETUVQRURGRy5wcm90byKZAgoL";
		buffer[2] = "QlBDR0lMRktDRkUSHQoHcmV0Y29kZRgBIAEoDjIMLkxPUERNRVBFREZHEiQK";
		buffer[3] = "CmVuZF9zdGF0dXMYAiABKA4yEC5CYXR0bGVFbmRTdGF0dXMSHgoDc3R0GAMg";
		buffer[4] = "ASgLMhEuQmF0dGxlU3RhdGlzdGljcxITCgtQTElBRk5QQU5HThgEIAEoDBIy";
		buffer[5] = "CgtKRk5DTUhDQUdHSBgFIAMoCzIdLkJQQ0dJTEZLQ0ZFLkpGTkNNSENBR0dI";
		buffer[6] = "RW50cnkSEwoLQ0pBSkJNQUpOSlAYBiABKA0SEwoLQk5BTEFDTUdLRkoYByAB";
		buffer[7] = "KA0aMgoQSkZOQ01IQ0FHR0hFbnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUY";
		buffer[8] = "AiABKA06AjgBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			BattleEndStatusReflection.Descriptor,
			BattleStatisticsReflection.Descriptor,
			LOPDMEPEDFGReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BPCGILFKCFE), BPCGILFKCFE.Parser, new string[7] { "Retcode", "EndStatus", "Stt", "PLIAFNPANGN", "JFNCMHCAGGH", "CJAJBMAJNJP", "BNALACMGKFJ" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
