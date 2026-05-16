using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMonopolyFriendRankingListScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMonopolyFriendRankingListScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "CidHZXRNb25vcG9seUZyaWVuZFJhbmtpbmdMaXN0U2NSc3AucHJvdG8aJ0dl";
		buffer[1] = "dE1vbm9wb2x5RnJpZW5kUmFua2luZ0xpc3RDc1JlcS5wcm90byKmAQohR2V0";
		buffer[2] = "TW9ub3BvbHlGcmllbmRSYW5raW5nTGlzdFNjUnNwEg8KB3JldGNvZGUYAiAB";
		buffer[3] = "KA0SNwoLSlBOQUxLRUZIT0gYBCADKAsyIi5HZXRNb25vcG9seUZyaWVuZFJh";
		buffer[4] = "bmtpbmdMaXN0Q3NSZXESNwoLS05OSUFFQk1IR00YBiABKAsyIi5HZXRNb25v";
		buffer[5] = "cG9seUZyaWVuZFJhbmtpbmdMaXN0Q3NSZXFCFqoCE01hcmNoN3RoSG9uZXku";
		buffer[6] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GetMonopolyFriendRankingListCsReqReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMonopolyFriendRankingListScRsp), GetMonopolyFriendRankingListScRsp.Parser, new string[3] { "Retcode", "JPNALKEFHOH", "KNNIAEBMHGM" }, null, null, null, null)
		}));
	}
}
