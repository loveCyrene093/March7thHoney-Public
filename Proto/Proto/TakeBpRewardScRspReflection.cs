using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeBpRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeBpRewardScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdUYWtlQnBSZXdhcmRTY1JzcC5wcm90bxoOSXRlbUxpc3QucHJvdG8iPwoR" + "VGFrZUJwUmV3YXJkU2NSc3ASDwoHcmV0Y29kZRgBIAEoDRIZCgZyZXdhcmQY" + "BCABKAsyCS5JdGVtTGlzdEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeBpRewardScRsp), TakeBpRewardScRsp.Parser, new string[2] { "Retcode", "Reward" }, null, null, null, null)
		}));
	}
}
