using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraDuelSetFriendDefendLineupCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraDuelSetFriendDefendLineupCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CitDaGltZXJhRHVlbFNldEZyaWVuZERlZmVuZExpbmV1cENzUmVxLnByb3Rv" + "IjUKJUNoaW1lcmFEdWVsU2V0RnJpZW5kRGVmZW5kTGluZXVwQ3NSZXESDAoE" + "c2xvdBgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraDuelSetFriendDefendLineupCsReq), ChimeraDuelSetFriendDefendLineupCsReq.Parser, new string[1] { "Slot" }, null, null, null, null)
		}));
	}
}
