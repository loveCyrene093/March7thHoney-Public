using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SubMissionRewardScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SubMissionRewardScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5TdWJNaXNzaW9uUmV3YXJkU2NOb3RpZnkucHJvdG8aDkl0ZW1MaXN0LnBy" + "b3RvIk0KGFN1Yk1pc3Npb25SZXdhcmRTY05vdGlmeRIWCg5zdWJfbWlzc2lv" + "bl9pZBgMIAEoDRIZCgZyZXdhcmQYDiABKAsyCS5JdGVtTGlzdEIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SubMissionRewardScNotify), SubMissionRewardScNotify.Parser, new string[2] { "SubMissionId", "Reward" }, null, null, null, null)
		}));
	}
}
