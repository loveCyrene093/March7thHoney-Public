using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SyncHandleFriendScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SyncHandleFriendScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch5TeW5jSGFuZGxlRnJpZW5kU2NOb3RpZnkucHJvdG8aFkZyaWVuZFNpbXBs";
		buffer[1] = "ZUluZm8ucHJvdG8iYgoYU3luY0hhbmRsZUZyaWVuZFNjTm90aWZ5EhEKCWlz";
		buffer[2] = "X2FjY2VwdBgCIAEoCBImCgtmcmllbmRfaW5mbxgMIAEoCzIRLkZyaWVuZFNp";
		buffer[3] = "bXBsZUluZm8SCwoDdWlkGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		buffer[4] = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { FriendSimpleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SyncHandleFriendScNotify), SyncHandleFriendScNotify.Parser, new string[3] { "IsAccept", "FriendInfo", "Uid" }, null, null, null, null)
		}));
	}
}
