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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChVTdGFydE1hdGNoQ3NSZXEucHJvdG8aE0ZpZ2h0R2FtZU1vZGUucHJvdG8a";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "FkxvYmJ5R2FtZUV4dEluZm8ucHJvdG8iXgoPU3RhcnRNYXRjaENzUmVxEiYK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "C0pIQ0pNS0RETk5GGAggASgLMhEuTG9iYnlHYW1lRXh0SW5mbxIjCgtQTE9C";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "TUJGUE5GSxgOIAEoDjIOLkZpZ2h0R2FtZU1vZGVCFqoCE01hcmNoN3RoSG9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			FightGameModeReflection.Descriptor,
			LobbyGameExtInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartMatchCsReq), StartMatchCsReq.Parser, new string[2] { "JHCJMKDDNNF", "PLOBMBFPNFK" }, null, null, null, null)
		}));
	}
}
