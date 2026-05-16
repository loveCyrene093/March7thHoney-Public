using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMbtiReportScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMbtiReportScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChhHZXRNYnRpUmVwb3J0U2NSc3AucHJvdG8aEUZDSk9MTUxNS0JBLnByb3Rv";
		buffer[1] = "GhFOUExBTEVGUElFRS5wcm90byLVAQoSR2V0TWJ0aVJlcG9ydFNjUnNwEiEK";
		buffer[2] = "C0pCTExJQ09PQ0FLGAMgAygLMgwuTlBMQUxFRlBJRUUSEwoLRUhNRUZBQkxP";
		buffer[3] = "REQYBCABKAUSDwoHcmV0Y29kZRgFIAEoDRIQCghwcm9ncmVzcxgGIAEoDRIh";
		buffer[4] = "CgtITkxETE9PQVBNSRgHIAMoCzIMLkZDSk9MTUxNS0JBEhMKC0hIUEFMSE1C";
		buffer[5] = "TEZLGAggASgIEhMKC1BNQUdPQk5ISkpEGAwgASgFEhcKD2lzX3Rha2VuX3Jl";
		buffer[6] = "d2FyZBgNIAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			FCJOLMLMKBAReflection.Descriptor,
			NPLALEFPIEEReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMbtiReportScRsp), GetMbtiReportScRsp.Parser, new string[8] { "JBLLICOOCAK", "EHMEFABLODD", "Retcode", "Progress", "HNLDLOOAPMI", "HHPALHMBLFK", "PMAGOBNHJJD", "IsTakenReward" }, null, null, null, null)
		}));
	}
}
