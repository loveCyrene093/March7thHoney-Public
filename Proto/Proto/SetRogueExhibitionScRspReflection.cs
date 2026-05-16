using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetRogueExhibitionScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetRogueExhibitionScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch1TZXRSb2d1ZUV4aGliaXRpb25TY1JzcC5wcm90bxoRRUVCT1BLSkVNSEsu";
		buffer[1] = "cHJvdG8aEUpKSE9ERkFISEtHLnByb3RvInAKF1NldFJvZ3VlRXhoaWJpdGlv";
		buffer[2] = "blNjUnNwEiEKC0ZKQklNSEFGTEVKGAMgAygLMgwuSkpIT0RGQUhIS0cSIQoL";
		buffer[3] = "T0hNUEJDSEFQS0QYDSADKAsyDC5FRUJPUEtKRU1ISxIPCgdyZXRjb2RlGA4g";
		buffer[4] = "ASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			EEBOPKJEMHKReflection.Descriptor,
			JJHODFAHHKGReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetRogueExhibitionScRsp), SetRogueExhibitionScRsp.Parser, new string[3] { "FJBIMHAFLEJ", "OHMPBCHAPKD", "Retcode" }, null, null, null, null)
		}));
	}
}
