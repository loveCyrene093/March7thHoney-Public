using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CakeRaceLikeFriendRankingInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CakeRaceLikeFriendRankingInfoScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CihDYWtlUmFjZUxpa2VGcmllbmRSYW5raW5nSW5mb1NjUnNwLnByb3RvGg5J";
		buffer[1] = "dGVtTGlzdC5wcm90byJ/CiJDYWtlUmFjZUxpa2VGcmllbmRSYW5raW5nSW5m";
		buffer[2] = "b1NjUnNwEhMKC3RlbGVwb3J0X2lkGAUgASgNEhMKC0hGSk5ET0FJRE9QGAYg";
		buffer[3] = "AygNEg8KB3JldGNvZGUYCCABKA0SHgoLcmV3YXJkX2xpc3QYDyABKAsyCS5J";
		buffer[4] = "dGVtTGlzdEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CakeRaceLikeFriendRankingInfoScRsp), CakeRaceLikeFriendRankingInfoScRsp.Parser, new string[4] { "TeleportId", "HFJNDOAIDOP", "Retcode", "RewardList" }, null, null, null, null)
		}));
	}
}
