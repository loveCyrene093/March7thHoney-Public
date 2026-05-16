using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IdleLiveTakeQuestEquipCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IdleLiveTakeQuestEquipCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFJZGxlTGl2ZVRha2VRdWVzdEVxdWlwQ3NSZXEucHJvdG8iQgobSWRsZUxp" + "dmVUYWtlUXVlc3RFcXVpcENzUmVxEhEKCURpc2NhcmRlZBgBIAEoCBIQCghx" + "dWVzdF9pZBgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IdleLiveTakeQuestEquipCsReq), IdleLiveTakeQuestEquipCsReq.Parser, new string[2] { "Discarded", "QuestId" }, null, null, null, null)
		}));
	}
}
