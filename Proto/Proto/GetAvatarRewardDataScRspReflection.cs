using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAvatarRewardDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAvatarRewardDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5HZXRBdmF0YXJSZXdhcmREYXRhU2NSc3AucHJvdG8iVwoYR2V0QXZhdGFy" + "UmV3YXJkRGF0YVNjUnNwEhcKD2lzX3Rha2VuX3Jld2FyZBgFIAEoCBIPCgdy" + "ZXRjb2RlGAYgASgNEhEKCWF2YXRhcl9pZBgIIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAvatarRewardDataScRsp), GetAvatarRewardDataScRsp.Parser, new string[3] { "IsTakenReward", "Retcode", "AvatarId" }, null, null, null, null)
		}));
	}
}
