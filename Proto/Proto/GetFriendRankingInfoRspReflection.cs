using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFriendRankingInfoRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFriendRankingInfoRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch1HZXRGcmllbmRSYW5raW5nSW5mb1JzcC5wcm90bxoRRUZCSUhKSE1JQ0Iu";
		buffer[1] = "cHJvdG8aE0ZpZ2h0R2FtZU1vZGUucHJvdG8icgoXR2V0RnJpZW5kUmFua2lu";
		buffer[2] = "Z0luZm9Sc3ASDwoHcmV0Y29kZRgNIAEoDRIjCgtQTE9CTUJGUE5GSxgOIAEo";
		buffer[3] = "DjIOLkZpZ2h0R2FtZU1vZGUSIQoLQ1BCR0xOR09DQkEYDyADKAsyDC5FRkJJ";
		buffer[4] = "SEpITUlDQkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			EFBIHJHMICBReflection.Descriptor,
			FightGameModeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendRankingInfoRsp), GetFriendRankingInfoRsp.Parser, new string[3] { "Retcode", "PLOBMBFPNFK", "CPBGLNGOCBA" }, null, null, null, null)
		}));
	}
}
