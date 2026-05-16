using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OJEJCHBHCJLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OJEJCHBHCJLReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFPSkVKQ0hCSENKTC5wcm90bxoRTUhLR0xNQkJDS1AucHJvdG8aEU5CSkdO";
		buffer[1] = "UFBESEtNLnByb3RvIo0BCgtPSkVKQ0hCSENKTBIhCgtHSkdLTEZDSE9GTxgB";
		buffer[2] = "IAMoCzIMLk5CSkdOUFBESEtNEhMKC0lOR0NESUFGQUZHGAIgASgNEhwKBnN0";
		buffer[3] = "YXR1cxgFIAEoDjIMLk1IS0dMTUJCQ0tQEhMKC0xNS0JESUNPTEtPGAwgASgN";
		buffer[4] = "EhMKC0xOT0RPSk9PUEJLGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		buffer[5] = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			MHKGLMBBCKPReflection.Descriptor,
			NBJGNPPDHKMReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OJEJCHBHCJL), OJEJCHBHCJL.Parser, new string[5] { "GJGKLFCHOFO", "INGCDIAFAFG", "Status", "LMKBDICOLKO", "LNODOJOOPBK" }, null, null, null, null)
		}));
	}
}
