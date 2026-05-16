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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChpSb2d1ZU1hZ2ljU3RhcnRTY1JzcC5wcm90bxoRQUhPTE9IQ0xMS0QucHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "dG8aEUpLQUlES0lHRUdQLnByb3RvIm0KFFJvZ3VlTWFnaWNTdGFydFNjUnNw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "EiEKC0FGTEpKSkZDQklOGAEgASgLMgwuSktBSURLSUdFR1ASDwoHcmV0Y29k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "ZRgJIAEoDRIhCgtISERMRUFEQkpHThgOIAEoCzIMLkFIT0xPSENMTEtEQhaq";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			AHOLOHCLLKDReflection.Descriptor,
			JKAIDKIGEGPReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicStartScRsp), RogueMagicStartScRsp.Parser, new string[3] { "AFLJJJFCBIN", "Retcode", "HHDLEADBJGN" }, null, null, null, null)
		}));
	}
}
