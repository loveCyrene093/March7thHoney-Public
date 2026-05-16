using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class APBOFCPJCAFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static APBOFCPJCAFReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFBUEJPRkNQSkNBRi5wcm90bxoRSklMSUNBTkhMTEMucHJvdG8aEVBHS05G";
		buffer[1] = "TUFOUE5JLnByb3RvIo0BCgtBUEJPRkNQSkNBRhIcCgZzdGF0dXMYASABKA4y";
		buffer[2] = "DC5KSUxJQ0FOSExMQxIhCgtHSkdLTEZDSE9GTxgDIAMoCzIMLlBHS05GTUFO";
		buffer[3] = "UE5JEhMKC0lOR0NESUFGQUZHGAggASgNEhMKC0xOT0RPSk9PUEJLGAsgASgN";
		buffer[4] = "EhMKC0xNS0JESUNPTEtPGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		buffer[5] = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			JILICANHLLCReflection.Descriptor,
			PGKNFMANPNIReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(APBOFCPJCAF), APBOFCPJCAF.Parser, new string[5] { "Status", "GJGKLFCHOFO", "INGCDIAFAFG", "LNODOJOOPBK", "LMKBDICOLKO" }, null, null, null, null)
		}));
	}
}
