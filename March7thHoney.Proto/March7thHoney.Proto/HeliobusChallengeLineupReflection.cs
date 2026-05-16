using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeliobusChallengeLineupReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeliobusChallengeLineupReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1IZWxpb2J1c0NoYWxsZW5nZUxpbmV1cC5wcm90byJVChdIZWxpb2J1c0No" + "YWxsZW5nZUxpbmV1cBIQCghza2lsbF9pZBgBIAEoDRIQCghncm91cF9pZBgC" + "IAEoDRIWCg5hdmF0YXJfaWRfbGlzdBgGIAMoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusChallengeLineup), HeliobusChallengeLineup.Parser, new string[3] { "SkillId", "GroupId", "AvatarIdList" }, null, null, null, null)
		}));
	}
}
