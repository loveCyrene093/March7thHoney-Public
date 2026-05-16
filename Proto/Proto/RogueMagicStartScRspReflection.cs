using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueMagicStartScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueMagicStartScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChpSb2d1ZU1hZ2ljU3RhcnRTY1JzcC5wcm90bxoRQUhPTE9IQ0xMS0QucHJv";
		buffer[1] = "dG8aEUpLQUlES0lHRUdQLnByb3RvIm0KFFJvZ3VlTWFnaWNTdGFydFNjUnNw";
		buffer[2] = "EiEKC0FGTEpKSkZDQklOGAEgASgLMgwuSktBSURLSUdFR1ASDwoHcmV0Y29k";
		buffer[3] = "ZRgJIAEoDRIhCgtISERMRUFEQkpHThgOIAEoCzIMLkFIT0xPSENMTEtEQhaq";
		buffer[4] = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			AHOLOHCLLKDReflection.Descriptor,
			JKAIDKIGEGPReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicStartScRsp), RogueMagicStartScRsp.Parser, new string[3] { "AFLJJJFCBIN", "Retcode", "HHDLEADBJGN" }, null, null, null, null)
		}));
	}
}
