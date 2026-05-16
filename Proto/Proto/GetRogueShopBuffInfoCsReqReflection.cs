using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRogueShopBuffInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRogueShopBuffInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9HZXRSb2d1ZVNob3BCdWZmSW5mb0NzUmVxLnByb3RvIlMKGUdldFJvZ3Vl" + "U2hvcEJ1ZmZJbmZvQ3NSZXESEwoLTk9LTk5NUE1HR04YBiABKAgSIQoZaW50" + "ZXJhY3RlZF9wcm9wX2VudGl0eV9pZBgJIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueShopBuffInfoCsReq), GetRogueShopBuffInfoCsReq.Parser, new string[2] { "NOKNNMPMGGN", "InteractedPropEntityId" }, null, null, null, null)
		}));
	}
}
