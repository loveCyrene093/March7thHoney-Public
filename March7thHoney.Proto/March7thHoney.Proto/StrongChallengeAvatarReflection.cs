using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StrongChallengeAvatarReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StrongChallengeAvatarReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtTdHJvbmdDaGFsbGVuZ2VBdmF0YXIucHJvdG8aEEF2YXRhclR5cGUucHJv" + "dG8iTAoVU3Ryb25nQ2hhbGxlbmdlQXZhdGFyEhEKCWF2YXRhcl9pZBgCIAEo" + "DRIgCgthdmF0YXJfdHlwZRgGIAEoDjILLkF2YXRhclR5cGVCFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { AvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StrongChallengeAvatar), StrongChallengeAvatar.Parser, new string[2] { "AvatarId", "AvatarType" }, null, null, null, null)
		}));
	}
}
