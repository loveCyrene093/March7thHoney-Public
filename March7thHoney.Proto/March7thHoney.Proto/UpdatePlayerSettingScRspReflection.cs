using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpdatePlayerSettingScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpdatePlayerSettingScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Ch5VcGRhdGVQbGF5ZXJTZXR0aW5nU2NSc3AucHJvdG8aGVVwZGF0ZVBsYXll";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "clNldHRpbmcucHJvdG8iWQoYVXBkYXRlUGxheWVyU2V0dGluZ1NjUnNwEg8K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "B3JldGNvZGUYAyABKA0SLAoOcGxheWVyX3NldHRpbmcYDCABKAsyFC5VcGRh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "dGVQbGF5ZXJTZXR0aW5nQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { UpdatePlayerSettingReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpdatePlayerSettingScRsp), UpdatePlayerSettingScRsp.Parser, new string[2] { "Retcode", "PlayerSetting" }, null, null, null, null)
		}));
	}
}
