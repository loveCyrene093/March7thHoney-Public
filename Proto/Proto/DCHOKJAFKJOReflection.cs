using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DCHOKJAFKJOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DCHOKJAFKJOReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFEQ0hPS0pBRktKTy5wcm90bxoRTEhETUJJTUdLQ0YucHJvdG8aEU1HRU1G";
		buffer[1] = "R0xESkxKLnByb3RvImQKC0RDSE9LSkFGS0pPEiEKC09NR1BOT0FJTk1CGAMg";
		buffer[2] = "AygLMgwuTEhETUJJTUdLQ0YSIQoLREpPREpPR0pQQkoYBSADKAsyDC5NR0VN";
		buffer[3] = "RkdMREpMShIPCgdyZXRjb2RlGAsgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		buffer[4] = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			LHDMBIMGKCFReflection.Descriptor,
			MGEMFGLDJLJReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DCHOKJAFKJO), DCHOKJAFKJO.Parser, new string[3] { "OMGPNOAINMB", "DJODJOGJPBJ", "Retcode" }, null, null, null, null)
		}));
	}
}
