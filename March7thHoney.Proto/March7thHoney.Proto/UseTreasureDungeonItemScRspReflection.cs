using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UseTreasureDungeonItemScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UseTreasureDungeonItemScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFVc2VUcmVhc3VyZUR1bmdlb25JdGVtU2NSc3AucHJvdG8aEUtQQkdNT0ND" + "TUxBLnByb3RvIlEKG1VzZVRyZWFzdXJlRHVuZ2Vvbkl0ZW1TY1JzcBIhCgtJ" + "S0hKTE1BS05DRBgEIAEoCzIMLktQQkdNT0NDTUxBEg8KB3JldGNvZGUYBiAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { KPBGMOCCMLAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UseTreasureDungeonItemScRsp), UseTreasureDungeonItemScRsp.Parser, new string[2] { "IKHJLMAKNCD", "Retcode" }, null, null, null, null)
		}));
	}
}
