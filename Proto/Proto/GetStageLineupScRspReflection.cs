using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetStageLineupScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetStageLineupScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlHZXRTdGFnZUxpbmV1cFNjUnNwLnByb3RvGhFMQktISk9JSk5LSS5wcm90" + "byJJChNHZXRTdGFnZUxpbmV1cFNjUnNwEg8KB3JldGNvZGUYAiABKA0SIQoL" + "TFBOTEFES01BRk8YDCADKAsyDC5MQktISk9JSk5LSUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { LBKHJOIJNKIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetStageLineupScRsp), GetStageLineupScRsp.Parser, new string[2] { "Retcode", "LPNLADKMAFO" }, null, null, null, null)
		}));
	}
}
