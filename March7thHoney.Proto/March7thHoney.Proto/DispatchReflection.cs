using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DispatchReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DispatchReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Cg5EaXNwYXRjaC5wcm90bxoQUmVnaW9uSW5mby5wcm90byJ+CghEaXNwYXRj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "aBIPCgdyZXRjb2RlGAEgASgNEgsKA21zZxgCIAEoCRIdChV0b3Bfc2V2ZXJf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "cmVnaW9uX25hbWUYAyABKAkSIAoLcmVnaW9uX2xpc3QYBCADKAsyCy5SZWdp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "b25JbmZvEhMKC0ZLQ0VITVBJQUdHGAUgASgJQhaqAhNNYXJjaDd0aEhvbmV5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { RegionInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(Dispatch), Dispatch.Parser, new string[5] { "Retcode", "Msg", "TopSeverRegionName", "RegionList", "FKCEHMPIAGG" }, null, null, null, null)
		}));
	}
}
