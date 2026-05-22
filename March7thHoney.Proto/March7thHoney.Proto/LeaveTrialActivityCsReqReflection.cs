using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LeaveTrialActivityCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LeaveTrialActivityCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1MZWF2ZVRyaWFsQWN0aXZpdHlDc1JlcS5wcm90byIrChdMZWF2ZVRyaWFs" + "QWN0aXZpdHlDc1JlcRIQCghzdGFnZV9pZBgHIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LeaveTrialActivityCsReq), LeaveTrialActivityCsReq.Parser, new string[1] { "StageId" }, null, null, null, null)
		}));
	}
}
