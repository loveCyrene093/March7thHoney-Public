using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerOutfitInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerOutfitInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZQbGF5ZXJPdXRmaXRJbmZvLnByb3RvIiwKEFBsYXllck91dGZpdEluZm8S" + "GAoQUGxheWVyT3V0Zml0TGlzdBgBIAMoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerOutfitInfo), PlayerOutfitInfo.Parser, new string[1] { "PlayerOutfitList" }, null, null, null, null)
		}));
	}
}
