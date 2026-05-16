using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneActorInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneActorInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRTY2VuZUFjdG9ySW5mby5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJqCg5T" + "Y2VuZUFjdG9ySW5mbxIRCgltYXBfbGF5ZXIYBCABKA0SCwoDdWlkGAcgASgN" + "EhYKDmJhc2VfYXZhdGFyX2lkGA4gASgNEiAKC2F2YXRhcl90eXBlGA8gASgO" + "MgsuQXZhdGFyVHlwZUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { AvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneActorInfo), SceneActorInfo.Parser, new string[4] { "MapLayer", "Uid", "BaseAvatarId", "AvatarType" }, null, null, null, null)
		}));
	}
}
