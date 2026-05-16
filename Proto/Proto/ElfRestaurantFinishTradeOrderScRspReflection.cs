using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ElfRestaurantFinishTradeOrderScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ElfRestaurantFinishTradeOrderScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CihFbGZSZXN0YXVyYW50RmluaXNoVHJhZGVPcmRlclNjUnNwLnByb3RvGhJJ";
		buffer[1] = "dGVtQ29zdERhdGEucHJvdG8aDkl0ZW1MaXN0LnByb3RvIo4BCiJFbGZSZXN0";
		buffer[2] = "YXVyYW50RmluaXNoVHJhZGVPcmRlclNjUnNwEhMKC0lJTUtJRkRLSkhPGAIg";
		buffer[3] = "ASgNEh4KC1BQTUFGQ0JOQUpGGAUgASgLMgkuSXRlbUxpc3QSDwoHcmV0Y29k";
		buffer[4] = "ZRgJIAEoDRIiCgtLQkVGS09OUEtHShgPIAEoCzINLkl0ZW1Db3N0RGF0YUIW";
		buffer[5] = "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ItemCostDataReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ElfRestaurantFinishTradeOrderScRsp), ElfRestaurantFinishTradeOrderScRsp.Parser, new string[4] { "IIMKIFDKJHO", "PPMAFCBNAJF", "Retcode", "KBEFKONPKGJ" }, null, null, null, null)
		}));
	}
}
