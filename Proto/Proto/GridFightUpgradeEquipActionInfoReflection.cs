using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightUpgradeEquipActionInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightUpgradeEquipActionInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVHcmlkRmlnaHRVcGdyYWRlRXF1aXBBY3Rpb25JbmZvLnByb3RvIkMKH0dy" + "aWRGaWdodFVwZ3JhZGVFcXVpcEFjdGlvbkluZm8SIAoYYXZhaWxhYmxlX2Vx" + "dWlwbWVudF9saXN0GA8gAygNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightUpgradeEquipActionInfo), GridFightUpgradeEquipActionInfo.Parser, new string[1] { "AvailableEquipmentList" }, null, null, null, null)
		}));
	}
}
