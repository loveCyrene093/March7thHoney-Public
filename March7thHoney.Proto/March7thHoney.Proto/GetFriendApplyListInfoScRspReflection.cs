using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFriendApplyListInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFriendApplyListInfoScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiFHZXRGcmllbmRBcHBseUxpc3RJbmZvU2NSc3AucHJvdG8aFUZyaWVuZEFw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "cGx5SW5mby5wcm90byJ1ChtHZXRGcmllbmRBcHBseUxpc3RJbmZvU2NSc3AS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "DwoHcmV0Y29kZRgDIAEoDRIXCg9zZW5kX2FwcGx5X2xpc3QYBSADKA0SLAoS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "cmVjZWl2ZV9hcHBseV9saXN0GAsgAygLMhAuRnJpZW5kQXBwbHlJbmZvQhaq";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { FriendApplyInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendApplyListInfoScRsp), GetFriendApplyListInfoScRsp.Parser, new string[3] { "Retcode", "SendApplyList", "ReceiveApplyList" }, null, null, null, null)
		}));
	}
}
