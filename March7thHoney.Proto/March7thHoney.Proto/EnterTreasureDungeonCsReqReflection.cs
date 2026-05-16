using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterTreasureDungeonCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterTreasureDungeonCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9FbnRlclRyZWFzdXJlRHVuZ2VvbkNzUmVxLnByb3RvGhFGTkdQQUxDTUJL" + "Sy5wcm90byJTChlFbnRlclRyZWFzdXJlRHVuZ2VvbkNzUmVxEiEKC2F2YXRh" + "cl9saXN0GAIgAygLMgwuRk5HUEFMQ01CS0sSEwoLdGFyZ2V0X3NpZGUYAyAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { FNGPALCMBKKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterTreasureDungeonCsReq), EnterTreasureDungeonCsReq.Parser, new string[2] { "AvatarList", "TargetSide" }, null, null, null, null)
		}));
	}
}
