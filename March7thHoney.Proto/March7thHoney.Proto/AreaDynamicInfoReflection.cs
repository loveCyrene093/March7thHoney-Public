using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AreaDynamicInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AreaDynamicInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVBcmVhRHluYW1pY0luZm8ucHJvdG8iPwoPQXJlYUR5bmFtaWNJbmZvEhYK" + "DmRpeV9keW5hbWljX2lkGAogASgNEhQKDGRpY2Vfc2xvdF9pZBgLIAEoDUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AreaDynamicInfo), AreaDynamicInfo.Parser, new string[2] { "DiyDynamicId", "DiceSlotId" }, null, null, null, null)
		}));
	}
}
