using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesApplyCardPieceScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesApplyCardPieceScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiJQbGFuZXRGZXNBcHBseUNhcmRQaWVjZVNjUnNwLnByb3RvIpgBChxQbGFu";
		buffer[1] = "ZXRGZXNBcHBseUNhcmRQaWVjZVNjUnNwEhMKC0VQR0lLR0NBREhNGAEgASgN";
		buffer[2] = "Eg8KB3JldGNvZGUYBCABKA0SEwoLQ0hFSEFPREhBT0MYBSABKAgSEwoLREpE";
		buffer[3] = "RUJLUEdKRE4YCSADKA0SEwoLdGVsZXBvcnRfaWQYCyABKA0SEwoLQUxKSUJD";
		buffer[4] = "Q0RIUEoYDSABKANCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesApplyCardPieceScRsp), PlanetFesApplyCardPieceScRsp.Parser, new string[6] { "EPGIKGCADHM", "Retcode", "CHEHAODHAOC", "DJDEBKPGJDN", "TeleportId", "ALJIBCCDHPJ" }, null, null, null, null)
		}));
	}
}
