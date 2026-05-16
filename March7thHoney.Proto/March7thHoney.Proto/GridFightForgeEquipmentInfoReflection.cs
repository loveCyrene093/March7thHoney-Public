using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightForgeEquipmentInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightForgeEquipmentInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFHcmlkRmlnaHRGb3JnZUVxdWlwbWVudEluZm8ucHJvdG8iPgobR3JpZEZp" + "Z2h0Rm9yZ2VFcXVpcG1lbnRJbmZvEh8KF2dyaWRfZmlnaHRfZXF1aXBtZW50" + "X2lkGAQgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightForgeEquipmentInfo), GridFightForgeEquipmentInfo.Parser, new string[1] { "GridFightEquipmentId" }, null, null, null, null)
		}));
	}
}
