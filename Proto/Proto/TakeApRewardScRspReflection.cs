using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeApRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeApRewardScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdUYWtlQXBSZXdhcmRTY1JzcC5wcm90bxoOSXRlbUxpc3QucHJvdG8iTgoR" + "VGFrZUFwUmV3YXJkU2NSc3ASGQoGcmV3YXJkGAUgASgLMgkuSXRlbUxpc3QS" + "DwoHcmV0Y29kZRgIIAEoDRINCgVsZXZlbBgLIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeApRewardScRsp), TakeApRewardScRsp.Parser, new string[3] { "Reward", "Retcode", "Level" }, null, null, null, null)
		}));
	}
}
