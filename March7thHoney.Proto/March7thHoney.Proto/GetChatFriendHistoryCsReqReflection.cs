using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetChatFriendHistoryCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetChatFriendHistoryCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9HZXRDaGF0RnJpZW5kSGlzdG9yeUNzUmVxLnByb3RvIhsKGUdldENoYXRG" + "cmllbmRIaXN0b3J5Q3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetChatFriendHistoryCsReq), GetChatFriendHistoryCsReq.Parser, null, null, null, null, null)
		}));
	}
}
