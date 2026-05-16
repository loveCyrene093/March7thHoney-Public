using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakePrestigeRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakePrestigeRewardScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1UYWtlUHJlc3RpZ2VSZXdhcmRTY1JzcC5wcm90bxoOSXRlbUxpc3QucHJv" + "dG8iVAoXVGFrZVByZXN0aWdlUmV3YXJkU2NSc3ASDwoHcmV0Y29kZRgEIAEo" + "DRINCgVsZXZlbBgMIAEoDRIZCgZyZXdhcmQYDyABKAsyCS5JdGVtTGlzdEIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakePrestigeRewardScRsp), TakePrestigeRewardScRsp.Parser, new string[3] { "Retcode", "Level", "Reward" }, null, null, null, null)
		}));
	}
}
