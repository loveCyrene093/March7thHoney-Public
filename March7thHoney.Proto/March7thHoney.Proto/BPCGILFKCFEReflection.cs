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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 0) = "ChFCUENHSUxGS0NGRS5wcm90bxoVQmF0dGxlRW5kU3RhdHVzLnByb3RvGhZC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 1) = "YXR0bGVTdGF0aXN0aWNzLnByb3RvGhFMT1BETUVQRURGRy5wcm90byKZAgoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 2) = "QlBDR0lMRktDRkUSHQoHcmV0Y29kZRgBIAEoDjIMLkxPUERNRVBFREZHEiQK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 3) = "CmVuZF9zdGF0dXMYAiABKA4yEC5CYXR0bGVFbmRTdGF0dXMSHgoDc3R0GAMg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 4) = "ASgLMhEuQmF0dGxlU3RhdGlzdGljcxITCgtQTElBRk5QQU5HThgEIAEoDBIy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 5) = "CgtKRk5DTUhDQUdHSBgFIAMoCzIdLkJQQ0dJTEZLQ0ZFLkpGTkNNSENBR0dI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 6) = "RW50cnkSEwoLQ0pBSkJNQUpOSlAYBiABKA0SEwoLQk5BTEFDTUdLRkoYByAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 7) = "KA0aMgoQSkZOQ01IQ0FHR0hFbnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 8) = "AiABKA06AjgBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray9<string>, string>(in buffer, 9))), new FileDescriptor[3]
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
