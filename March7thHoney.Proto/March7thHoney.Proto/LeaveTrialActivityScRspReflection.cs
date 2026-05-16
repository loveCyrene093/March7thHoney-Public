using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LeaveTrialActivityScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LeaveTrialActivityScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1MZWF2ZVRyaWFsQWN0aXZpdHlTY1JzcC5wcm90byI8ChdMZWF2ZVRyaWFs" + "QWN0aXZpdHlTY1JzcBIQCghzdGFnZV9pZBgHIAEoDRIPCgdyZXRjb2RlGA8g" + "ASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LeaveTrialActivityScRsp), LeaveTrialActivityScRsp.Parser, new string[2] { "StageId", "Retcode" }, null, null, null, null)
		}));
	}
}
