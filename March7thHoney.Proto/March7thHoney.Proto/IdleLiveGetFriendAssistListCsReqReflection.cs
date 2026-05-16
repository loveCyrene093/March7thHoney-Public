using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IdleLiveGetFriendAssistListCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IdleLiveGetFriendAssistListCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZJZGxlTGl2ZUdldEZyaWVuZEFzc2lzdExpc3RDc1JlcS5wcm90byI3CiBJ" + "ZGxlTGl2ZUdldEZyaWVuZEFzc2lzdExpc3RDc1JlcRITCgt0YXJnZXRfc2lk" + "ZRgCIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IdleLiveGetFriendAssistListCsReq), IdleLiveGetFriendAssistListCsReq.Parser, new string[1] { "TargetSide" }, null, null, null, null)
		}));
	}
}
