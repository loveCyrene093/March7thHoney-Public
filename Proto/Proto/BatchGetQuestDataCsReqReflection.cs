using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BatchGetQuestDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BatchGetQuestDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxCYXRjaEdldFF1ZXN0RGF0YUNzUmVxLnByb3RvIiwKFkJhdGNoR2V0UXVl" + "c3REYXRhQ3NSZXESEgoKcXVlc3RfbGlzdBgFIAMoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BatchGetQuestDataCsReq), BatchGetQuestDataCsReq.Parser, new string[1] { "QuestList" }, null, null, null, null)
		}));
	}
}
