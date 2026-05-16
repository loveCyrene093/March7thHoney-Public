using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AvatarPathSkillTreeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AvatarPathSkillTreeReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlBdmF0YXJQYXRoU2tpbGxUcmVlLnByb3RvIjYKE0F2YXRhclBhdGhTa2ls" + "bFRyZWUSEAoIcG9pbnRfaWQYBiABKA0SDQoFbGV2ZWwYByABKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AvatarPathSkillTree), AvatarPathSkillTree.Parser, new string[2] { "PointId", "Level" }, null, null, null, null)
		}));
	}
}
