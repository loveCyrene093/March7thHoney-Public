using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterRogueMapRoomCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterRogueMapRoomCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxFbnRlclJvZ3VlTWFwUm9vbUNzUmVxLnByb3RvIj4KFkVudGVyUm9ndWVN" + "YXBSb29tQ3NSZXESEwoLSENNSkRNRk5FTkUYDiABKA0SDwoHcm9vbV9pZBgP" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterRogueMapRoomCsReq), EnterRogueMapRoomCsReq.Parser, new string[2] { "HCMJDMFNENE", "RoomId" }, null, null, null, null)
		}));
	}
}
