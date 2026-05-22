using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetFriendRemarkNameCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetFriendRemarkNameCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5TZXRGcmllbmRSZW1hcmtOYW1lQ3NSZXEucHJvdG8iTAoYU2V0RnJpZW5k" + "UmVtYXJrTmFtZUNzUmVxEhMKC3JlbWFya19uYW1lGAQgASgJEg4KBnJlYXNv" + "bhgFIAEoDRILCgN1aWQYCyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetFriendRemarkNameCsReq), SetFriendRemarkNameCsReq.Parser, new string[3] { "RemarkName", "Reason", "Uid" }, null, null, null, null)
		}));
	}
}
