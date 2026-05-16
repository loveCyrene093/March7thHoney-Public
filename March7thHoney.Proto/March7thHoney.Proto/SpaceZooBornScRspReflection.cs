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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChdTcGFjZVpvb0Jvcm5TY1JzcC5wcm90bxoRRE1OREpCUEdFS0cucHJvdG8a";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "EUxLSk1MUEpFUEdHLnByb3RvIn8KEVNwYWNlWm9vQm9yblNjUnNwEhMKC0JG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "QUxMQ0dJUE9HGAMgASgIEiEKC0RISE1CRkhLTEpHGAQgAygLMgwuRE1OREpC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "UEdFS0cSDwoHcmV0Y29kZRgFIAEoDRIhCgtEUFBITkRDT0RNRxgLIAEoCzIM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "LkxLSk1MUEpFUEdHQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			DMNDJBPGEKGReflection.Descriptor,
			LKJMLPJEPGGReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SpaceZooBornScRsp), SpaceZooBornScRsp.Parser, new string[4] { "BFALLCGIPOG", "DHHMBFHKLJG", "Retcode", "DPPHNDCODMG" }, null, null, null, null)
		}));
	}
}
