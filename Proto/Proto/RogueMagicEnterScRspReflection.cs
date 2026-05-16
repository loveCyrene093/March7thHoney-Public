using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueMagicEnterScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueMagicEnterScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChpSb2d1ZU1hZ2ljRW50ZXJTY1JzcC5wcm90bxoRQUhPTE9IQ0xMS0QucHJv";
		buffer[1] = "dG8aEUpLQUlES0lHRUdQLnByb3RvIm0KFFJvZ3VlTWFnaWNFbnRlclNjUnNw";
		buffer[2] = "EiEKC0hIRExFQURCSkdOGAIgASgLMgwuQUhPTE9IQ0xMS0QSIQoLQUZMSkpK";
		buffer[3] = "RkNCSU4YAyABKAsyDC5KS0FJREtJR0VHUBIPCgdyZXRjb2RlGA0gASgNQhaq";
		buffer[4] = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			AHOLOHCLLKDReflection.Descriptor,
			JKAIDKIGEGPReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicEnterScRsp), RogueMagicEnterScRsp.Parser, new string[3] { "HHDLEADBJGN", "AFLJJJFCBIN", "Retcode" }, null, null, null, null)
		}));
	}
}
