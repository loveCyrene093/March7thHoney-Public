using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FateTakeExpRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FateTakeExpRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChxGYXRlVGFrZUV4cFJld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlzdC5wcm90";
		buffer[1] = "byJuChZGYXRlVGFrZUV4cFJld2FyZFNjUnNwEhMKC0FLQ0pMSUVMTENDGAIg";
		buffer[2] = "AygNEhkKBnJld2FyZBgHIAEoCzIJLkl0ZW1MaXN0EhMKC05MQ0RJS05ITUpN";
		buffer[3] = "GAkgAygNEg8KB3JldGNvZGUYCyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		buffer[4] = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FateTakeExpRewardScRsp), FateTakeExpRewardScRsp.Parser, new string[4] { "AKCJLIELLCC", "Reward", "NLCDIKNHMJM", "Retcode" }, null, null, null, null)
		}));
	}
}
