using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeRechargeGiftRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeRechargeGiftRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFUYWtlUmVjaGFyZ2VHaWZ0UmV3YXJkQ3NSZXEucHJvdG8iMAobVGFrZVJl" + "Y2hhcmdlR2lmdFJld2FyZENzUmVxEhEKCWdpZnRfdHlwZRgFIAEoDUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeRechargeGiftRewardCsReq), TakeRechargeGiftRewardCsReq.Parser, new string[1] { "GiftType" }, null, null, null, null)
		}));
	}
}
