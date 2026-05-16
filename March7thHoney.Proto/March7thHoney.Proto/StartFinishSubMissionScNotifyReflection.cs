using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartFinishSubMissionScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartFinishSubMissionScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNTdGFydEZpbmlzaFN1Yk1pc3Npb25TY05vdGlmeS5wcm90byI3Ch1TdGFy" + "dEZpbmlzaFN1Yk1pc3Npb25TY05vdGlmeRIWCg5zdWJfbWlzc2lvbl9pZBgP" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartFinishSubMissionScNotify), StartFinishSubMissionScNotify.Parser, new string[1] { "SubMissionId" }, null, null, null, null)
		}));
	}
}
