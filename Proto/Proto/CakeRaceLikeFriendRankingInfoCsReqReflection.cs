using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CakeRaceLikeFriendRankingInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CakeRaceLikeFriendRankingInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihDYWtlUmFjZUxpa2VGcmllbmRSYW5raW5nSW5mb0NzUmVxLnByb3RvIjkK" + "IkNha2VSYWNlTGlrZUZyaWVuZFJhbmtpbmdJbmZvQ3NSZXESEwoLdGVsZXBv" + "cnRfaWQYBSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CakeRaceLikeFriendRankingInfoCsReq), CakeRaceLikeFriendRankingInfoCsReq.Parser, new string[1] { "TeleportId" }, null, null, null, null)
		}));
	}
}
