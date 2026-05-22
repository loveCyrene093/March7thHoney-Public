using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraDuelGetFriendListCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraDuelGetFriendListCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNDaGltZXJhRHVlbEdldEZyaWVuZExpc3RDc1JlcS5wcm90byIfCh1DaGlt" + "ZXJhRHVlbEdldEZyaWVuZExpc3RDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraDuelGetFriendListCsReq), ChimeraDuelGetFriendListCsReq.Parser, null, null, null, null, null)
		}));
	}
}
