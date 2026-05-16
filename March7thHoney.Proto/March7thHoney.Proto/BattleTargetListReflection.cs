using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BattleTargetListReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BattleTargetListReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZCYXR0bGVUYXJnZXRMaXN0LnByb3RvGhJCYXR0bGVUYXJnZXQucHJvdG8i" + "PQoQQmF0dGxlVGFyZ2V0TGlzdBIpChJiYXR0bGVfdGFyZ2V0X2xpc3QYASAD" + "KAsyDS5CYXR0bGVUYXJnZXRCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[1] { BattleTargetReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BattleTargetList), BattleTargetList.Parser, new string[1] { "BattleTargetList_" }, null, null, null, null)
		}));
	}
}
