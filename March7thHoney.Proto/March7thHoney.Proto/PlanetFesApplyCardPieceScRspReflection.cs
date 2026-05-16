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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiJQbGFuZXRGZXNBcHBseUNhcmRQaWVjZVNjUnNwLnByb3RvIpgBChxQbGFu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "ZXRGZXNBcHBseUNhcmRQaWVjZVNjUnNwEhMKC0VQR0lLR0NBREhNGAEgASgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "Eg8KB3JldGNvZGUYBCABKA0SEwoLQ0hFSEFPREhBT0MYBSABKAgSEwoLREpE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "RUJLUEdKRE4YCSADKA0SEwoLdGVsZXBvcnRfaWQYCyABKA0SEwoLQUxKSUJD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "Q0RIUEoYDSABKANCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesApplyCardPieceScRsp), PlanetFesApplyCardPieceScRsp.Parser, new string[6] { "EPGIKGCADHM", "Retcode", "CHEHAODHAOC", "DJDEBKPGJDN", "TeleportId", "ALJIBCCDHPJ" }, null, null, null, null)
		}));
	}
}
