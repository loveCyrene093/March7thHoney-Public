using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartStarFightLevelCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartStarFightLevelCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch5TdGFydFN0YXJGaWdodExldmVsQ3NSZXEucHJvdG8aEUhKS0dNQ0hGSEZN";
		buffer[1] = "LnByb3RvImQKGFN0YXJ0U3RhckZpZ2h0TGV2ZWxDc1JlcRIQCghncm91cF9p";
		buffer[2] = "ZBgJIAEoDRITCgtJTk9NRkZBSUVPQRgKIAEoDRIhCgthdmF0YXJfbGlzdBgL";
		buffer[3] = "IAMoCzIMLkhKS0dNQ0hGSEZNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		buffer[4] = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { HJKGMCHFHFMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartStarFightLevelCsReq), StartStarFightLevelCsReq.Parser, new string[3] { "GroupId", "INOMFFAIEOA", "AvatarList" }, null, null, null, null)
		}));
	}
}
