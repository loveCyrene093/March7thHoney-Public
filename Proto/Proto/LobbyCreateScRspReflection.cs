using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LobbyCreateScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LobbyCreateScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChZMb2JieUNyZWF0ZVNjUnNwLnByb3RvGhFBREhOSkFESUpBQy5wcm90bxoT";
		buffer[1] = "RmlnaHRHYW1lTW9kZS5wcm90bxoRUEJJQ0pDUERMR0QucHJvdG8itAEKEExv";
		buffer[2] = "YmJ5Q3JlYXRlU2NSc3ASEwoLQ0hFT0RNS0FISk0YASABKA0SIQoLUE9GT0NN";
		buffer[3] = "SUhKSUEYBSABKAsyDC5QQklDSkNQRExHRBIjCgtQTE9CTUJGUE5GSxgGIAEo";
		buffer[4] = "DjIOLkZpZ2h0R2FtZU1vZGUSDwoHcm9vbV9pZBgHIAEoBBIPCgdyZXRjb2Rl";
		buffer[5] = "GAkgASgNEiEKC0JJRUJGSEVDRVBNGA4gAygLMgwuQURITkpBRElKQUNCFqoC";
		buffer[6] = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			ADHNJADIJACReflection.Descriptor,
			FightGameModeReflection.Descriptor,
			PBICJCPDLGDReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LobbyCreateScRsp), LobbyCreateScRsp.Parser, new string[6] { "CHEODMKAHJM", "POFOCMIHJIA", "PLOBMBFPNFK", "RoomId", "Retcode", "BIEBFHECEPM" }, null, null, null, null)
		}));
	}
}
