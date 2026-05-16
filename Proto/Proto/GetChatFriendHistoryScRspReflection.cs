using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetChatFriendHistoryScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetChatFriendHistoryScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch9HZXRDaGF0RnJpZW5kSGlzdG9yeVNjUnNwLnByb3RvGhdGcmllbmRIaXN0";
		buffer[1] = "b3J5SW5mby5wcm90byJdChlHZXRDaGF0RnJpZW5kSGlzdG9yeVNjUnNwEg8K";
		buffer[2] = "B3JldGNvZGUYBSABKA0SLwoTZnJpZW5kX2hpc3RvcnlfaW5mbxgNIAMoCzIS";
		buffer[3] = "LkZyaWVuZEhpc3RvcnlJbmZvQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		buffer[4] = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { FriendHistoryInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetChatFriendHistoryScRsp), GetChatFriendHistoryScRsp.Parser, new string[2] { "Retcode", "FriendHistoryInfo" }, null, null, null, null)
		}));
	}
}
