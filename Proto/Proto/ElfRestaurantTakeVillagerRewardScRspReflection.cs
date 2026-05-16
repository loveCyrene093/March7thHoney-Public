using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ElfRestaurantTakeVillagerRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ElfRestaurantTakeVillagerRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CipFbGZSZXN0YXVyYW50VGFrZVZpbGxhZ2VyUmV3YXJkU2NSc3AucHJvdG8a";
		buffer[1] = "EU9BTUhFSUpCSUtHLnByb3RvIloKJEVsZlJlc3RhdXJhbnRUYWtlVmlsbGFn";
		buffer[2] = "ZXJSZXdhcmRTY1JzcBIPCgdyZXRjb2RlGAMgASgNEiEKC0hBTEZHTEdMRExP";
		buffer[3] = "GA0gAygLMgwuT0FNSEVJSkJJS0dCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		buffer[4] = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { OAMHEIJBIKGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ElfRestaurantTakeVillagerRewardScRsp), ElfRestaurantTakeVillagerRewardScRsp.Parser, new string[2] { "Retcode", "HALFGLGLDLO" }, null, null, null, null)
		}));
	}
}
