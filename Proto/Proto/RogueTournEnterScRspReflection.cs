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
		buffer[0] = "ChpSb2d1ZVRvdXJuRW50ZXJTY1JzcC5wcm90bxoRQVBNSERHUERHTlAucHJv";
		buffer[1] = "dG8aEUJGRUlQRUxGQ0RGLnByb3RvIm0KFFJvZ3VlVG91cm5FbnRlclNjUnNw";
		buffer[2] = "EiEKC0hIRExFQURCSkdOGAcgASgLMgwuQVBNSERHUERHTlASIQoLQUZMSkpK";
		buffer[3] = "RkNCSU4YCyABKAsyDC5CRkVJUEVMRkNERhIPCgdyZXRjb2RlGAwgASgNQhaq";
		buffer[4] = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			APMHDGPDGNPReflection.Descriptor,
			BFEIPELFCDFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournEnterScRsp), RogueTournEnterScRsp.Parser, new string[3] { "HHDLEADBJGN", "AFLJJJFCBIN", "Retcode" }, null, null, null, null)
		}));
	}
}
