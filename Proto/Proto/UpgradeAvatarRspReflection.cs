using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpgradeAvatarRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpgradeAvatarRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZVcGdyYWRlQXZhdGFyUnNwLnByb3RvGhZEaWNlQ29tYmF0QXZhdGFyLnBy" + "b3RvIksKEFVwZ3JhZGVBdmF0YXJSc3ASJgoLT0pDQkdHT0VFSUUYBCABKAsy" + "ES5EaWNlQ29tYmF0QXZhdGFyEg8KB3JldGNvZGUYCiABKA1CFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { DiceCombatAvatarReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpgradeAvatarRsp), UpgradeAvatarRsp.Parser, new string[2] { "OJCBGGOEEIE", "Retcode" }, null, null, null, null)
		}));
	}
}
