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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "CidHZXRNb25vcG9seUZyaWVuZFJhbmtpbmdMaXN0U2NSc3AucHJvdG8aJ0dl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "dE1vbm9wb2x5RnJpZW5kUmFua2luZ0xpc3RDc1JlcS5wcm90byKmAQohR2V0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "TW9ub3BvbHlGcmllbmRSYW5raW5nTGlzdFNjUnNwEg8KB3JldGNvZGUYAiAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "KA0SNwoLSlBOQUxLRUZIT0gYBCADKAsyIi5HZXRNb25vcG9seUZyaWVuZFJh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "bmtpbmdMaXN0Q3NSZXESNwoLS05OSUFFQk1IR00YBiABKAsyIi5HZXRNb25v";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "cG9seUZyaWVuZFJhbmtpbmdMaXN0Q3NSZXFCFqoCE01hcmNoN3RoSG9uZXku";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[1] { GetMonopolyFriendRankingListCsReqReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMonopolyFriendRankingListScRsp), GetMonopolyFriendRankingListScRsp.Parser, new string[3] { "Retcode", "JPNALKEFHOH", "KNNIAEBMHGM" }, null, null, null, null)
		}));
	}
}
