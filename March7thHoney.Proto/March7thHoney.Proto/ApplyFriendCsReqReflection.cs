using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ApplyFriendCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ApplyFriendCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZBcHBseUZyaWVuZENzUmVxLnByb3RvGhdGcmllbmRBcHBseVNvdXJjZS5w" + "cm90byJDChBBcHBseUZyaWVuZENzUmVxEiIKBnNvdXJjZRgIIAEoDjISLkZy" + "aWVuZEFwcGx5U291cmNlEgsKA3VpZBgPIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { FriendApplySourceReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ApplyFriendCsReq), ApplyFriendCsReq.Parser, new string[2] { "Source", "Uid" }, null, null, null, null)
		}));
	}
}
