using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraDuelSaveFriendPvpLineupCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraDuelSaveFriendPvpLineupCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CilDaGltZXJhRHVlbFNhdmVGcmllbmRQdnBMaW5ldXBDc1JlcS5wcm90byIz" + "CiNDaGltZXJhRHVlbFNhdmVGcmllbmRQdnBMaW5ldXBDc1JlcRIMCgRzbG90" + "GAMgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraDuelSaveFriendPvpLineupCsReq), ChimeraDuelSaveFriendPvpLineupCsReq.Parser, new string[1] { "Slot" }, null, null, null, null)
		}));
	}
}
