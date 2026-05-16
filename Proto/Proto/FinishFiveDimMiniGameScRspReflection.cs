using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishFiveDimMiniGameScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishFiveDimMiniGameScRspReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "CiBGaW5pc2hGaXZlRGltTWluaUdhbWVTY1JzcC5wcm90bxoOSXRlbUxpc3Qu";
		buffer[1] = "cHJvdG8iiwIKGkZpbmlzaEZpdmVEaW1NaW5pR2FtZVNjUnNwEh4KC01FTkFB";
		buffer[2] = "UE5OS0dFGAIgASgLMgkuSXRlbUxpc3QSEwoLTkNPRElNUEFOQ0MYAyABKA0S";
		buffer[3] = "EAoIc2NvcmVfaWQYBSABKA0SHgoLRU5NRktKSU9FT0MYBiABKAsyCS5JdGVt";
		buffer[4] = "TGlzdBIMCgRnb2xkGAcgASgNEhMKC0tFQUJQQk9OT0tNGAggASgNEhMKC0dD";
		buffer[5] = "UE5DRURBTUFCGAogASgNEhMKC0NIUEFNUE5NQ09FGAsgASgIEg8KB3JldGNv";
		buffer[6] = "ZGUYDCABKA0SEwoLUEJEQkpPSENKRk8YDSABKAISEwoLT0pJQUFHSkJKQUYY";
		buffer[7] = "DyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishFiveDimMiniGameScRsp), FinishFiveDimMiniGameScRsp.Parser, new string[11]
			{
				"MENAAPNNKGE", "NCODIMPANCC", "ScoreId", "ENMFKJIOEOC", "Gold", "KEABPBONOKM", "GCPNCEDAMAB", "CHPAMPNMCOE", "Retcode", "PBDBJOHCJFO",
				"OJIAAGJBJAF"
			}, null, null, null, null)
		}));
	}
}
