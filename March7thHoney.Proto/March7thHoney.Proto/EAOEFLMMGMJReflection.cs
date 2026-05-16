using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EAOEFLMMGMJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EAOEFLMMGMJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFQU9FRkxNTUdNSi5wcm90byINCgtFQU9FRkxNTUdNSkIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EAOEFLMMGMJ), EAOEFLMMGMJ.Parser, null, null, null, null, null)
		}));
	}
}
