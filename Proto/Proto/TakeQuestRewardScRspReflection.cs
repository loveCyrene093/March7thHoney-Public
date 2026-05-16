using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeQuestRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeQuestRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChpUYWtlUXVlc3RSZXdhcmRTY1JzcC5wcm90bxoOSXRlbUxpc3QucHJvdG8i";
		buffer[1] = "cwoUVGFrZVF1ZXN0UmV3YXJkU2NSc3ASGQoGcmV3YXJkGAEgASgLMgkuSXRl";
		buffer[2] = "bUxpc3QSEwoLRk5JUEtNRkpNQ0UYAiADKA0SGgoSc3VjY19xdWVzdF9pZF9s";
		buffer[3] = "aXN0GAQgAygNEg8KB3JldGNvZGUYBSABKA1CFqoCE01hcmNoN3RoSG9uZXku";
		buffer[4] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeQuestRewardScRsp), TakeQuestRewardScRsp.Parser, new string[4] { "Reward", "FNIPKMFJMCE", "SuccQuestIdList", "Retcode" }, null, null, null, null)
		}));
	}
}
