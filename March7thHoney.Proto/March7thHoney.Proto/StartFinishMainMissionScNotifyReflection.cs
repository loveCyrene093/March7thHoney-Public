using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartFinishMainMissionScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartFinishMainMissionScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRTdGFydEZpbmlzaE1haW5NaXNzaW9uU2NOb3RpZnkucHJvdG8iOQoeU3Rh" + "cnRGaW5pc2hNYWluTWlzc2lvblNjTm90aWZ5EhcKD21haW5fbWlzc2lvbl9p" + "ZBgHIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartFinishMainMissionScNotify), StartFinishMainMissionScNotify.Parser, new string[1] { "MainMissionId" }, null, null, null, null)
		}));
	}
}
