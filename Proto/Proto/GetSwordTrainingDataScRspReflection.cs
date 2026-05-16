using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetSwordTrainingDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetSwordTrainingDataScRspReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "Ch9HZXRTd29yZFRyYWluaW5nRGF0YVNjUnNwLnByb3RvGhFMTEtFR0FPTEdH";
		buffer[1] = "Ri5wcm90bxoRTE1CSERDRlBQTEwucHJvdG8i2wEKGUdldFN3b3JkVHJhaW5p";
		buffer[2] = "bmdEYXRhU2NSc3ASEwoLRkhOUEFQQU1OTkUYAyADKA0SDwoHcmV0Y29kZRgG";
		buffer[3] = "IAEoDRITCgtGT0VLRE1FQUxLRhgHIAMoDRITCgtIRUVIUE1MQUhQSxgJIAMo";
		buffer[4] = "DRITCgtLRUFGTEdOTEtCTxgKIAEoCBIhCgtCTUtBRUZBS05GShgMIAEoCzIM";
		buffer[5] = "LkxNQkhEQ0ZQUExMEhMKC0dDSkZMRUxJTkpPGA0gASgNEiEKC0ZDQVBCUEhM";
		buffer[6] = "TkNKGA4gASgLMgwuTExLRUdBT0xHR0ZCFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		buffer[7] = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			LLKEGAOLGGFReflection.Descriptor,
			LMBHDCFPPLLReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetSwordTrainingDataScRsp), GetSwordTrainingDataScRsp.Parser, new string[8] { "FHNPAPAMNNE", "Retcode", "FOEKDMEALKF", "HEEHPMLAHPK", "KEAFLGNLKBO", "BMKAEFAKNFJ", "GCJFLELINJO", "FCAPBPHLNCJ" }, null, null, null, null)
		}));
	}
}
