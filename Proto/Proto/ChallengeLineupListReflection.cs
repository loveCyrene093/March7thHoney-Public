using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengeLineupListReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengeLineupListReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlDaGFsbGVuZ2VMaW5ldXBMaXN0LnByb3RvGhlDaGFsbGVuZ2VBdmF0YXJJ" + "bmZvLnByb3RvIkAKE0NoYWxsZW5nZUxpbmV1cExpc3QSKQoLYXZhdGFyX2xp" + "c3QYDyADKAsyFC5DaGFsbGVuZ2VBdmF0YXJJbmZvQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { ChallengeAvatarInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeLineupList), ChallengeLineupList.Parser, new string[1] { "AvatarList" }, null, null, null, null)
		}));
	}
}
