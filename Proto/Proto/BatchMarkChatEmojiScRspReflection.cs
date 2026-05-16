using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BatchMarkChatEmojiScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BatchMarkChatEmojiScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1CYXRjaE1hcmtDaGF0RW1vamlTY1JzcC5wcm90byJIChdCYXRjaE1hcmtD" + "aGF0RW1vamlTY1JzcBIcChRtYXJrZWRfZW1vamlfaWRfbGlzdBgCIAMoDRIP" + "CgdyZXRjb2RlGAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BatchMarkChatEmojiScRsp), BatchMarkChatEmojiScRsp.Parser, new string[2] { "MarkedEmojiIdList", "Retcode" }, null, null, null, null)
		}));
	}
}
