using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BDEMABPLPKOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BDEMABPLPKOReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "ChFCREVNQUJQTFBLTy5wcm90bxoRRUZFR0tESEVNRk4ucHJvdG8aEUpJUEFD";
		buffer[1] = "REVKS0pDLnByb3RvIo4CCgtCREVNQUJQTFBLTxIhCgtCUENLRkxKSUdDSRgD";
		buffer[2] = "IAMoCzIMLkpJUEFDREVKS0pDEhMKC0NGSU9OS0tJUEpMGAQgASgIEiEKC0JG";
		buffer[3] = "TlBDSk9NR0ZMGAUgASgLMgwuRUZFR0tESEVNRk4SEwoLR0FGUEVDR0dJQ0MY";
		buffer[4] = "BiABKA0SEgoKaGFzX3Bhc3NlZBgJIAEoCBITCgtETk5IQ05DS0pDTRgLIAEo";
		buffer[5] = "AxIyCgtLQkhFR0JDQUFNRxgOIAMoCzIdLkJERU1BQlBMUEtPLktCSEVHQkNB";
		buffer[6] = "QU1HRW50cnkaMgoQS0JIRUdCQ0FBTUdFbnRyeRILCgNrZXkYASABKA0SDQoF";
		buffer[7] = "dmFsdWUYAiABKA06AjgBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		buffer[8] = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			EFEGKDHEMFNReflection.Descriptor,
			JIPACDEJKJCReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BDEMABPLPKO), BDEMABPLPKO.Parser, new string[7] { "BPCKFLJIGCI", "CFIONKKIPJL", "BFNPCJOMGFL", "GAFPECGGICC", "HasPassed", "DNNHCNCKJCM", "KBHEGBCAAMG" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
