using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishQuestCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishQuestCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZGaW5pc2hRdWVzdENzUmVxLnByb3RvIkcKEEZpbmlzaFF1ZXN0Q3NSZXES" + "DwoHcHJvcF9pZBgJIAEoDRIQCghncm91cF9pZBgOIAEoDRIQCghxdWVzdF9p" + "ZBgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishQuestCsReq), FinishQuestCsReq.Parser, new string[3] { "PropId", "GroupId", "QuestId" }, null, null, null, null)
		}));
	}
}
