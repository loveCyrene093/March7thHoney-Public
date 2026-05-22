using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EntityMotionReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EntityMotionReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJFbnRpdHlNb3Rpb24ucHJvdG8aEE1vdGlvbkluZm8ucHJvdG8iZgoMRW50" + "aXR5TW90aW9uEhMKC0FHTkhOQUlPUERGGAMgASgIEhsKBm1vdGlvbhgEIAEo" + "CzILLk1vdGlvbkluZm8SEQoJbWFwX2xheWVyGAogASgNEhEKCWVudGl0eV9p" + "ZBgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { MotionInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EntityMotion), EntityMotion.Parser, new string[4] { "AGNHNAIOPDF", "Motion", "MapLayer", "EntityId" }, null, null, null, null)
		}));
	}
}
