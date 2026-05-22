using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LobbyJoinCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LobbyJoinCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRMb2JieUpvaW5Dc1JlcS5wcm90bxoWTG9iYnlHYW1lRXh0SW5mby5wcm90" + "byJeCg5Mb2JieUpvaW5Dc1JlcRImCgtKSENKTUtERE5ORhgFIAEoCzIRLkxv" + "YmJ5R2FtZUV4dEluZm8SEwoLR0ZGSU1HRUtETkwYBiABKAkSDwoHcm9vbV9p" + "ZBgHIAEoBEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { LobbyGameExtInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LobbyJoinCsReq), LobbyJoinCsReq.Parser, new string[3] { "JHCJMKDDNNF", "GFFIMGEKDNL", "RoomId" }, null, null, null, null)
		}));
	}
}
