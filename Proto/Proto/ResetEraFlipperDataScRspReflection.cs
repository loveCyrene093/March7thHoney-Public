using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ResetEraFlipperDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ResetEraFlipperDataScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch5SZXNldEVyYUZsaXBwZXJEYXRhU2NSc3AucHJvdG8aGEVyYUZsaXBwZXJE";
		buffer[1] = "YXRhTGlzdC5wcm90byJjChhSZXNldEVyYUZsaXBwZXJEYXRhU2NSc3ASIQoE";
		buffer[2] = "ZGF0YRgEIAEoCzITLkVyYUZsaXBwZXJEYXRhTGlzdBIPCgdyZXRjb2RlGAog";
		buffer[3] = "ASgNEhMKC09JUExKSklPRElMGA0gASgIQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		buffer[4] = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { EraFlipperDataListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ResetEraFlipperDataScRsp), ResetEraFlipperDataScRsp.Parser, new string[3] { "Data", "Retcode", "OIPLJJIODIL" }, null, null, null, null)
		}));
	}
}
