using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyGameBingoFlipCardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyGameBingoFlipCardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiRNb25vcG9seUdhbWVCaW5nb0ZsaXBDYXJkU2NSc3AucHJvdG8icAoeTW9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "b3BvbHlHYW1lQmluZ29GbGlwQ2FyZFNjUnNwEhMKC0pLTEZNT0hJQ01PGAIg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "ASgIEhMKC0VBT0ZKRkFGQUhPGAMgAygNEg8KB3JldGNvZGUYDSABKA0SEwoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "RVBMQkNORk1MSUwYDiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyGameBingoFlipCardScRsp), MonopolyGameBingoFlipCardScRsp.Parser, new string[4] { "JKLFMOHICMO", "EAOFJFAFAHO", "Retcode", "EPLBCNFMLIL" }, null, null, null, null)
		}));
	}
}
