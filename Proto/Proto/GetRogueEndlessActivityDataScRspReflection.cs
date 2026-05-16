using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRogueEndlessActivityDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRogueEndlessActivityDataScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CiZHZXRSb2d1ZUVuZGxlc3NBY3Rpdml0eURhdGFTY1JzcC5wcm90bxoRTkxQ";
		buffer[1] = "UENGR0ZGREUucHJvdG8ijgEKIEdldFJvZ3VlRW5kbGVzc0FjdGl2aXR5RGF0";
		buffer[2] = "YVNjUnNwEhMKC0xMSEdHUEpCTklOGAEgASgNEhMKC01PR0JOSk9IS0xBGAMg";
		buffer[3] = "AygNEhoKBGRhdGEYBiADKAsyDC5OTFBQQ0ZHRkZERRITCgtOQUdMSkRDTEdH";
		buffer[4] = "QhgHIAEoDRIPCgdyZXRjb2RlGAsgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		buffer[5] = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { NLPPCFGFFDEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueEndlessActivityDataScRsp), GetRogueEndlessActivityDataScRsp.Parser, new string[5] { "LLHGGPJBNIN", "MOGBNJOHKLA", "Data", "NAGLJDCLGGB", "Retcode" }, null, null, null, null)
		}));
	}
}
