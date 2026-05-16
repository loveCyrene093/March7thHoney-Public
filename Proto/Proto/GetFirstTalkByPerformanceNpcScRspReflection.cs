using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFirstTalkByPerformanceNpcScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFirstTalkByPerformanceNpcScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CidHZXRGaXJzdFRhbGtCeVBlcmZvcm1hbmNlTnBjU2NSc3AucHJvdG8aIE5w";
		buffer[1] = "Y01lZXRCeVBlcmZvcm1hbmNlU3RhdHVzLnByb3RvIm8KIUdldEZpcnN0VGFs";
		buffer[2] = "a0J5UGVyZm9ybWFuY2VOcGNTY1JzcBI5ChRucGNfbWVldF9zdGF0dXNfbGlz";
		buffer[3] = "dBgKIAMoCzIbLk5wY01lZXRCeVBlcmZvcm1hbmNlU3RhdHVzEg8KB3JldGNv";
		buffer[4] = "ZGUYDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { NpcMeetByPerformanceStatusReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFirstTalkByPerformanceNpcScRsp), GetFirstTalkByPerformanceNpcScRsp.Parser, new string[2] { "NpcMeetStatusList", "Retcode" }, null, null, null, null)
		}));
	}
}
