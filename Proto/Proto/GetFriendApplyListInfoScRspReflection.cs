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
		buffer[0] = "CiFHZXRGcmllbmRBcHBseUxpc3RJbmZvU2NSc3AucHJvdG8aFUZyaWVuZEFw";
		buffer[1] = "cGx5SW5mby5wcm90byJ1ChtHZXRGcmllbmRBcHBseUxpc3RJbmZvU2NSc3AS";
		buffer[2] = "DwoHcmV0Y29kZRgDIAEoDRIXCg9zZW5kX2FwcGx5X2xpc3QYBSADKA0SLAoS";
		buffer[3] = "cmVjZWl2ZV9hcHBseV9saXN0GAsgAygLMhAuRnJpZW5kQXBwbHlJbmZvQhaq";
		buffer[4] = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { FriendApplyInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendApplyListInfoScRsp), GetFriendApplyListInfoScRsp.Parser, new string[3] { "Retcode", "SendApplyList", "ReceiveApplyList" }, null, null, null, null)
		}));
	}
}
