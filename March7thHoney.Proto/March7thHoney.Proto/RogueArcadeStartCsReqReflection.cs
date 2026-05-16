using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueArcadeStartCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueArcadeStartCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtSb2d1ZUFyY2FkZVN0YXJ0Q3NSZXEucHJvdG8iRQoVUm9ndWVBcmNhZGVT" + "dGFydENzUmVxEg8KB3Jvb21faWQYCiABKA0SGwoTYmFzZV9hdmF0YXJfaWRf" + "bGlzdBgLIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueArcadeStartCsReq), RogueArcadeStartCsReq.Parser, new string[2] { "RoomId", "BaseAvatarIdList" }, null, null, null, null)
		}));
	}
}
