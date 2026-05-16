using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AvatarSkillTreeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AvatarSkillTreeReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVBdmF0YXJTa2lsbFRyZWUucHJvdG8iMgoPQXZhdGFyU2tpbGxUcmVlEhAK" + "CHBvaW50X2lkGAEgASgNEg0KBWxldmVsGAIgASgNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AvatarSkillTree), AvatarSkillTree.Parser, new string[2] { "PointId", "Level" }, null, null, null, null)
		}));
	}
}
