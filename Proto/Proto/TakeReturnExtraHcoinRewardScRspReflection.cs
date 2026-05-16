using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeReturnExtraHcoinRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeReturnExtraHcoinRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiVUYWtlUmV0dXJuRXh0cmFIY29pblJld2FyZFNjUnNwLnByb3RvGg5JdGVt";
		buffer[1] = "TGlzdC5wcm90byJiCh9UYWtlUmV0dXJuRXh0cmFIY29pblJld2FyZFNjUnNw";
		buffer[2] = "EhMKC0dFRUZPS0ZCUERLGAQgASgNEg8KB3JldGNvZGUYBiABKA0SGQoGcmV3";
		buffer[3] = "YXJkGAcgASgLMgkuSXRlbUxpc3RCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		buffer[4] = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeReturnExtraHcoinRewardScRsp), TakeReturnExtraHcoinRewardScRsp.Parser, new string[3] { "GEEFOKFBPDK", "Retcode", "Reward" }, null, null, null, null)
		}));
	}
}
