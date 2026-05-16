using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BattleGridFigntAvatarCoreRoleInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BattleGridFigntAvatarCoreRoleInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidCYXR0bGVHcmlkRmlnbnRBdmF0YXJDb3JlUm9sZUluZm8ucHJvdG8iWAoh" + "QmF0dGxlR3JpZEZpZ250QXZhdGFyQ29yZVJvbGVJbmZvEh4KFmdyaWRfZmln" + "aHRfYXZhdGFyX2xpc3QYASADKA0SEwoLQ0JEQkZBTkpHUEIYAiADKA1CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BattleGridFigntAvatarCoreRoleInfo), BattleGridFigntAvatarCoreRoleInfo.Parser, new string[2] { "GridFightAvatarList", "CBDBFANJGPB" }, null, null, null, null)
		}));
	}
}
