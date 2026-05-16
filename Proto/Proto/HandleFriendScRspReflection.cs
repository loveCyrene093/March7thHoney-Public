using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HandleFriendScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HandleFriendScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChdIYW5kbGVGcmllbmRTY1JzcC5wcm90bxoWRnJpZW5kU2ltcGxlSW5mby5w";
		buffer[1] = "cm90byJsChFIYW5kbGVGcmllbmRTY1JzcBIPCgdyZXRjb2RlGAIgASgNEhEK";
		buffer[2] = "CWlzX2FjY2VwdBgDIAEoCBILCgN1aWQYDCABKA0SJgoLZnJpZW5kX2luZm8Y";
		buffer[3] = "DiABKAsyES5GcmllbmRTaW1wbGVJbmZvQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		buffer[4] = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { FriendSimpleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HandleFriendScRsp), HandleFriendScRsp.Parser, new string[4] { "Retcode", "IsAccept", "Uid", "FriendInfo" }, null, null, null, null)
		}));
	}
}
