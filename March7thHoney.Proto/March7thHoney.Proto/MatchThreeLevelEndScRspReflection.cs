using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MatchThreeLevelEndScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MatchThreeLevelEndScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1NYXRjaFRocmVlTGV2ZWxFbmRTY1JzcC5wcm90byJRChdNYXRjaFRocmVl" + "TGV2ZWxFbmRTY1JzcBIPCgdyZXRjb2RlGAIgASgNEhAKCGxldmVsX2lkGAQg" + "ASgNEhMKC0RQQ0ZCRENFS0pMGA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MatchThreeLevelEndScRsp), MatchThreeLevelEndScRsp.Parser, new string[3] { "Retcode", "LevelId", "DPCFBDCEKJL" }, null, null, null, null)
		}));
	}
}
