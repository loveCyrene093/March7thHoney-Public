using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MarkChatEmojiScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MarkChatEmojiScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhNYXJrQ2hhdEVtb2ppU2NSc3AucHJvdG8iTQoSTWFya0NoYXRFbW9qaVNj" + "UnNwEg8KB3JldGNvZGUYBiABKA0SEAoIZXh0cmFfaWQYCSABKA0SFAoMaXNf" + "cmVtb3ZlX2lkGAogASgIQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MarkChatEmojiScRsp), MarkChatEmojiScRsp.Parser, new string[3] { "Retcode", "ExtraId", "IsRemoveId" }, null, null, null, null)
		}));
	}
}
