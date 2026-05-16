using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueMagicReviveAvatarCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueMagicReviveAvatarCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSb2d1ZU1hZ2ljUmV2aXZlQXZhdGFyQ3NSZXEucHJvdG8iXQobUm9ndWVN" + "YWdpY1Jldml2ZUF2YXRhckNzUmVxEiEKGWludGVyYWN0ZWRfcHJvcF9lbnRp" + "dHlfaWQYAyABKA0SGwoTYmFzZV9hdmF0YXJfaWRfbGlzdBgFIAMoDUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicReviveAvatarCsReq), RogueMagicReviveAvatarCsReq.Parser, new string[2] { "InteractedPropEntityId", "BaseAvatarIdList" }, null, null, null, null)
		}));
	}
}
