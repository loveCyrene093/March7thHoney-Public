using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CakeRaceGetFriendRankingInfoListScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CakeRaceGetFriendRankingInfoListScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CitDYWtlUmFjZUdldEZyaWVuZFJhbmtpbmdJbmZvTGlzdFNjUnNwLnByb3Rv";
		buffer[1] = "GhFNR0ZFTUhLSUNORC5wcm90byJwCiVDYWtlUmFjZUdldEZyaWVuZFJhbmtp";
		buffer[2] = "bmdJbmZvTGlzdFNjUnNwEg8KB3JldGNvZGUYByABKA0SEwoLSEZKTkRPQUlE";
		buffer[3] = "T1AYDCADKA0SIQoLQ1BCR0xOR09DQkEYDiADKAsyDC5NR0ZFTUhLSUNOREIW";
		buffer[4] = "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MGFEMHKICNDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CakeRaceGetFriendRankingInfoListScRsp), CakeRaceGetFriendRankingInfoListScRsp.Parser, new string[3] { "Retcode", "HFJNDOAIDOP", "CPBGLNGOCBA" }, null, null, null, null)
		}));
	}
}
