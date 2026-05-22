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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Ch5SZXNldEVyYUZsaXBwZXJEYXRhU2NSc3AucHJvdG8aGEVyYUZsaXBwZXJE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "YXRhTGlzdC5wcm90byJjChhSZXNldEVyYUZsaXBwZXJEYXRhU2NSc3ASIQoE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "ZGF0YRgEIAEoCzITLkVyYUZsaXBwZXJEYXRhTGlzdBIPCgdyZXRjb2RlGAog";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "ASgNEhMKC09JUExKSklPRElMGA0gASgIQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { EraFlipperDataListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ResetEraFlipperDataScRsp), ResetEraFlipperDataScRsp.Parser, new string[3] { "Data", "Retcode", "OIPLJJIODIL" }, null, null, null, null)
		}));
	}
}
