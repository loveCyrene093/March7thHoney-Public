using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartMatchCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartMatchCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChVTdGFydE1hdGNoQ3NSZXEucHJvdG8aE0ZpZ2h0R2FtZU1vZGUucHJvdG8a";
		buffer[1] = "FkxvYmJ5R2FtZUV4dEluZm8ucHJvdG8iXgoPU3RhcnRNYXRjaENzUmVxEiYK";
		buffer[2] = "C0pIQ0pNS0RETk5GGAggASgLMhEuTG9iYnlHYW1lRXh0SW5mbxIjCgtQTE9C";
		buffer[3] = "TUJGUE5GSxgOIAEoDjIOLkZpZ2h0R2FtZU1vZGVCFqoCE01hcmNoN3RoSG9u";
		buffer[4] = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			FightGameModeReflection.Descriptor,
			LobbyGameExtInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartMatchCsReq), StartMatchCsReq.Parser, new string[2] { "JHCJMKDDNNF", "PLOBMBFPNFK" }, null, null, null, null)
		}));
	}
}
