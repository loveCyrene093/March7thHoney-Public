using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SpaceZooBornScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SpaceZooBornScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChdTcGFjZVpvb0Jvcm5TY1JzcC5wcm90bxoRRE1OREpCUEdFS0cucHJvdG8a";
		buffer[1] = "EUxLSk1MUEpFUEdHLnByb3RvIn8KEVNwYWNlWm9vQm9yblNjUnNwEhMKC0JG";
		buffer[2] = "QUxMQ0dJUE9HGAMgASgIEiEKC0RISE1CRkhLTEpHGAQgAygLMgwuRE1OREpC";
		buffer[3] = "UEdFS0cSDwoHcmV0Y29kZRgFIAEoDRIhCgtEUFBITkRDT0RNRxgLIAEoCzIM";
		buffer[4] = "LkxLSk1MUEpFUEdHQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			DMNDJBPGEKGReflection.Descriptor,
			LKJMLPJEPGGReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SpaceZooBornScRsp), SpaceZooBornScRsp.Parser, new string[4] { "BFALLCGIPOG", "DHHMBFHKLJG", "Retcode", "DPPHNDCODMG" }, null, null, null, null)
		}));
	}
}
