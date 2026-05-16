using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartTrialActivityCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartTrialActivityCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1TdGFydFRyaWFsQWN0aXZpdHlDc1JlcS5wcm90byIrChdTdGFydFRyaWFs" + "QWN0aXZpdHlDc1JlcRIQCghzdGFnZV9pZBgEIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartTrialActivityCsReq), StartTrialActivityCsReq.Parser, new string[1] { "StageId" }, null, null, null, null)
		}));
	}
}
