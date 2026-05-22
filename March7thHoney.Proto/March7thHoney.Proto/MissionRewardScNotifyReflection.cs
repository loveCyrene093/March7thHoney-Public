using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MissionRewardScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MissionRewardScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtNaXNzaW9uUmV3YXJkU2NOb3RpZnkucHJvdG8aDkl0ZW1MaXN0LnByb3Rv" + "ImMKFU1pc3Npb25SZXdhcmRTY05vdGlmeRIWCg5zdWJfbWlzc2lvbl9pZBgC" + "IAEoDRIXCg9tYWluX21pc3Npb25faWQYBiABKA0SGQoGcmV3YXJkGAogASgL" + "MgkuSXRlbUxpc3RCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MissionRewardScNotify), MissionRewardScNotify.Parser, new string[3] { "SubMissionId", "MainMissionId", "Reward" }, null, null, null, null)
		}));
	}
}
