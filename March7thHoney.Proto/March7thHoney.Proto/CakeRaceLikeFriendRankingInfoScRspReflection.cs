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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CihDYWtlUmFjZUxpa2VGcmllbmRSYW5raW5nSW5mb1NjUnNwLnByb3RvGg5J";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "dGVtTGlzdC5wcm90byJ/CiJDYWtlUmFjZUxpa2VGcmllbmRSYW5raW5nSW5m";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "b1NjUnNwEhMKC3RlbGVwb3J0X2lkGAUgASgNEhMKC0hGSk5ET0FJRE9QGAYg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "AygNEg8KB3JldGNvZGUYCCABKA0SHgoLcmV3YXJkX2xpc3QYDyABKAsyCS5J";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "dGVtTGlzdEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CakeRaceLikeFriendRankingInfoScRsp), CakeRaceLikeFriendRankingInfoScRsp.Parser, new string[4] { "TeleportId", "HFJNDOAIDOP", "Retcode", "RewardList" }, null, null, null, null)
		}));
	}
}
