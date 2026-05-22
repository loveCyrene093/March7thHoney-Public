using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MarkChatEmojiCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MarkChatEmojiCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhNYXJrQ2hhdEVtb2ppQ3NSZXEucHJvdG8iPAoSTWFya0NoYXRFbW9qaUNz" + "UmVxEhAKCGV4dHJhX2lkGAwgASgNEhQKDGlzX3JlbW92ZV9pZBgOIAEoCEIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MarkChatEmojiCsReq), MarkChatEmojiCsReq.Parser, new string[2] { "ExtraId", "IsRemoveId" }, null, null, null, null)
		}));
	}
}
