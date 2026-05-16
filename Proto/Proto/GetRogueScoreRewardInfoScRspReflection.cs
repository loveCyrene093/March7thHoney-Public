using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRogueScoreRewardInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRogueScoreRewardInfoScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJHZXRSb2d1ZVNjb3JlUmV3YXJkSW5mb1NjUnNwLnByb3RvGhFCR0tJTkNG" + "R0tHSS5wcm90byJSChxHZXRSb2d1ZVNjb3JlUmV3YXJkSW5mb1NjUnNwEiEK" + "C0xKTUZHREZCTENLGAEgASgLMgwuQkdLSU5DRkdLR0kSDwoHcmV0Y29kZRgD" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { BGKINCFGKGIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueScoreRewardInfoScRsp), GetRogueScoreRewardInfoScRsp.Parser, new string[2] { "LJMFGDFBLCK", "Retcode" }, null, null, null, null)
		}));
	}
}
