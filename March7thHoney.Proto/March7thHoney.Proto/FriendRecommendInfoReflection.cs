using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FriendRecommendInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FriendRecommendInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlGcmllbmRSZWNvbW1lbmRJbmZvLnByb3RvGhZQbGF5ZXJTaW1wbGVJbmZv" + "LnByb3RvIlEKE0ZyaWVuZFJlY29tbWVuZEluZm8SEgoKYXBwbHlfdGltZRgJ" + "IAEoCBImCgtwbGF5ZXJfaW5mbxgLIAEoCzIRLlBsYXllclNpbXBsZUluZm9C" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { PlayerSimpleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FriendRecommendInfo), FriendRecommendInfo.Parser, new string[2] { "ApplyTime", "PlayerInfo" }, null, null, null, null)
		}));
	}
}
