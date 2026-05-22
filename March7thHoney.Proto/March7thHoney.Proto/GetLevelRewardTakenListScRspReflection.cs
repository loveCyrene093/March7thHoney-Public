using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetLevelRewardTakenListScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetLevelRewardTakenListScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJHZXRMZXZlbFJld2FyZFRha2VuTGlzdFNjUnNwLnByb3RvIlAKHEdldExl" + "dmVsUmV3YXJkVGFrZW5MaXN0U2NSc3ASHwoXbGV2ZWxfcmV3YXJkX3Rha2Vu" + "X2xpc3QYAyADKA0SDwoHcmV0Y29kZRgOIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetLevelRewardTakenListScRsp), GetLevelRewardTakenListScRsp.Parser, new string[2] { "LevelRewardTakenList", "Retcode" }, null, null, null, null)
		}));
	}
}
