using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KFKDIEAJPCJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KFKDIEAJPCJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLRktESUVBSlBDSi5wcm90byIiCgtLRktESUVBSlBDShITCgtDSkZMTE9C" + "TE5ORxgDIAMoCUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KFKDIEAJPCJ), KFKDIEAJPCJ.Parser, new string[1] { "CJFLLOBLNNG" }, null, null, null, null)
		}));
	}
}
