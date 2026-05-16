using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BatchMarkChatEmojiCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BatchMarkChatEmojiCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1CYXRjaE1hcmtDaGF0RW1vamlDc1JlcS5wcm90byI3ChdCYXRjaE1hcmtD" + "aGF0RW1vamlDc1JlcRIcChRtYXJrZWRfZW1vamlfaWRfbGlzdBgHIAMoDUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BatchMarkChatEmojiCsReq), BatchMarkChatEmojiCsReq.Parser, new string[1] { "MarkedEmojiIdList" }, null, null, null, null)
		}));
	}
}
