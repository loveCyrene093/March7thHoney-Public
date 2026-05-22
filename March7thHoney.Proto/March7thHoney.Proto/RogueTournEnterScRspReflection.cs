using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournEnterScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournEnterScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChpSb2d1ZVRvdXJuRW50ZXJTY1JzcC5wcm90bxoRQVBNSERHUERHTlAucHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "dG8aEUJGRUlQRUxGQ0RGLnByb3RvIm0KFFJvZ3VlVG91cm5FbnRlclNjUnNw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "EiEKC0hIRExFQURCSkdOGAcgASgLMgwuQVBNSERHUERHTlASIQoLQUZMSkpK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "RkNCSU4YCyABKAsyDC5CRkVJUEVMRkNERhIPCgdyZXRjb2RlGAwgASgNQhaq";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			APMHDGPDGNPReflection.Descriptor,
			BFEIPELFCDFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournEnterScRsp), RogueTournEnterScRsp.Parser, new string[3] { "HHDLEADBJGN", "AFLJJJFCBIN", "Retcode" }, null, null, null, null)
		}));
	}
}
