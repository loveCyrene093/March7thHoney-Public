using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LobbyCreateCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LobbyCreateCsReqReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChZMb2JieUNyZWF0ZUNzUmVxLnByb3RvGhNGaWdodEdhbWVNb2RlLnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "GhZMb2JieUdhbWVFeHRJbmZvLnByb3RvGhFQQklDSkNQRExHRC5wcm90byKX";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "AQoQTG9iYnlDcmVhdGVDc1JlcRImCgtKSENKTUtERE5ORhgBIAEoCzIRLkxv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "YmJ5R2FtZUV4dEluZm8SEwoLQ0hFT0RNS0FISk0YBSABKA0SIwoLUExPQk1C";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "RlBORksYDCABKA4yDi5GaWdodEdhbWVNb2RlEiEKC1BPRk9DTUlISklBGA0g";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "ASgLMgwuUEJJQ0pDUERMR0RCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[3]
		{
			FightGameModeReflection.Descriptor,
			LobbyGameExtInfoReflection.Descriptor,
			PBICJCPDLGDReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LobbyCreateCsReq), LobbyCreateCsReq.Parser, new string[4] { "JHCJMKDDNNF", "CHEODMKAHJM", "PLOBMBFPNFK", "POFOCMIHJIA" }, null, null, null, null)
		}));
	}
}
