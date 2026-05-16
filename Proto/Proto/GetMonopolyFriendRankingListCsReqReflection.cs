using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMonopolyFriendRankingListCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMonopolyFriendRankingListCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CidHZXRNb25vcG9seUZyaWVuZFJhbmtpbmdMaXN0Q3NSZXEucHJvdG8ihAEK";
		buffer[1] = "IUdldE1vbm9wb2x5RnJpZW5kUmFua2luZ0xpc3RDc1JlcRITCgtDSE5QTUlC";
		buffer[2] = "SE9BQRgCIAEoDRITCgtGS0FLQ0NKQ0dBRhgDIAEoDRITCgtOTkFPSE1NSUJF";
		buffer[3] = "QhgFIAEoDRITCgtETERHSEpFSkRQRhgLIAEoDRILCgN1aWQYDyABKA1CFqoC";
		buffer[4] = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMonopolyFriendRankingListCsReq), GetMonopolyFriendRankingListCsReq.Parser, new string[5] { "CHNPMIBHOAA", "FKAKCCJCGAF", "NNAOHMMIBEB", "DLDGHJEJDPF", "Uid" }, null, null, null, null)
		}));
	}
}
