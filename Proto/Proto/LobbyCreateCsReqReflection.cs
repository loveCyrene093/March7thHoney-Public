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
		buffer[0] = "ChZMb2JieUNyZWF0ZUNzUmVxLnByb3RvGhNGaWdodEdhbWVNb2RlLnByb3Rv";
		buffer[1] = "GhZMb2JieUdhbWVFeHRJbmZvLnByb3RvGhFQQklDSkNQRExHRC5wcm90byKX";
		buffer[2] = "AQoQTG9iYnlDcmVhdGVDc1JlcRImCgtKSENKTUtERE5ORhgBIAEoCzIRLkxv";
		buffer[3] = "YmJ5R2FtZUV4dEluZm8SEwoLQ0hFT0RNS0FISk0YBSABKA0SIwoLUExPQk1C";
		buffer[4] = "RlBORksYDCABKA4yDi5GaWdodEdhbWVNb2RlEiEKC1BPRk9DTUlISklBGA0g";
		buffer[5] = "ASgLMgwuUEJJQ0pDUERMR0RCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		buffer[6] = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
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
