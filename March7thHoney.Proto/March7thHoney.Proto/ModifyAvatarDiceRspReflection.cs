using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ModifyAvatarDiceRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ModifyAvatarDiceRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlNb2RpZnlBdmF0YXJEaWNlUnNwLnByb3RvGhZEaWNlQ29tYmF0QXZhdGFy" + "LnByb3RvIk4KE01vZGlmeUF2YXRhckRpY2VSc3ASDwoHcmV0Y29kZRgBIAEo" + "DRImCgtPSkNCR0dPRUVJRRgMIAEoCzIRLkRpY2VDb21iYXRBdmF0YXJCFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { DiceCombatAvatarReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ModifyAvatarDiceRsp), ModifyAvatarDiceRsp.Parser, new string[2] { "Retcode", "OJCBGGOEEIE" }, null, null, null, null)
		}));
	}
}
