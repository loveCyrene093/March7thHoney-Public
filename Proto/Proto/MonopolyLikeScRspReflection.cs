using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyLikeScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyLikeScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdNb25vcG9seUxpa2VTY1JzcC5wcm90bxoOSXRlbUxpc3QucHJvdG8iWQoR" + "TW9ub3BvbHlMaWtlU2NSc3ASHgoLcmV3YXJkX2xpc3QYBCABKAsyCS5JdGVt" + "TGlzdBITCgt0ZWxlcG9ydF9pZBgLIAEoDRIPCgdyZXRjb2RlGA0gASgNQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyLikeScRsp), MonopolyLikeScRsp.Parser, new string[3] { "RewardList", "TeleportId", "Retcode" }, null, null, null, null)
		}));
	}
}
