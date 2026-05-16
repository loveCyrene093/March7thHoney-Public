using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ElationActivityAvatarReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ElationActivityAvatarReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtFbGF0aW9uQWN0aXZpdHlBdmF0YXIucHJvdG8aEEF2YXRhclR5cGUucHJv" + "dG8iTAoVRWxhdGlvbkFjdGl2aXR5QXZhdGFyEiAKC2F2YXRhcl90eXBlGAgg" + "ASgOMgsuQXZhdGFyVHlwZRIRCglhdmF0YXJfaWQYDyABKA1CFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { AvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ElationActivityAvatar), ElationActivityAvatar.Parser, new string[2] { "AvatarType", "AvatarId" }, null, null, null, null)
		}));
	}
}
