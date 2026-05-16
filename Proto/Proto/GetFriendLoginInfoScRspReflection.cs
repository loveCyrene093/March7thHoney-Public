using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFriendLoginInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFriendLoginInfoScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch1HZXRGcmllbmRMb2dpbkluZm9TY1JzcC5wcm90byKAAQoXR2V0RnJpZW5k";
		buffer[1] = "TG9naW5JbmZvU2NSc3ASDwoHcmV0Y29kZRgCIAEoDRIVCg1GcmllbmRVaWRM";
		buffer[2] = "aXN0GAMgAygNEhMKC0JLSkpGRUhQTkFPGAUgASgIEhMKC0xBQkJFTEJKS0lJ";
		buffer[3] = "GAsgASgIEhMKC0JISk9OSE9MRUFBGA0gAygNQhaqAhNNYXJjaDd0aEhvbmV5";
		buffer[4] = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendLoginInfoScRsp), GetFriendLoginInfoScRsp.Parser, new string[5] { "Retcode", "FriendUidList", "BKJJFEHPNAO", "LABBELBJKII", "BHJONHOLEAA" }, null, null, null, null)
		}));
	}
}
