using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RecomendedAvatarInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RecomendedAvatarInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpSZWNvbWVuZGVkQXZhdGFySW5mby5wcm90byJhChRSZWNvbWVuZGVkQXZh" + "dGFySW5mbxIWCg5hdmF0YXJfaWRfbGlzdBgCIAMoDRIbChNyZWNvbW1lbmRf" + "YXZhdGFyX2lkGAggASgNEhQKDHJlbGljX3NldF9pZBgJIAEoDUIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RecomendedAvatarInfo), RecomendedAvatarInfo.Parser, new string[3] { "AvatarIdList", "RecommendAvatarId", "RelicSetId" }, null, null, null, null)
		}));
	}
}
