using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAetherDivideChallengeInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAetherDivideChallengeInfoScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CidHZXRBZXRoZXJEaXZpZGVDaGFsbGVuZ2VJbmZvU2NSc3AucHJvdG8icwoh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "R2V0QWV0aGVyRGl2aWRlQ2hhbGxlbmdlSW5mb1NjUnNwEhMKC0hQTUhGREdN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "R0dIGAIgAygNEhMKC0pBR0hFTVBCTUxEGAogAygNEhMKC0tBR0NFQURDS0ZK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "GA0gASgNEg8KB3JldGNvZGUYDiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAetherDivideChallengeInfoScRsp), GetAetherDivideChallengeInfoScRsp.Parser, new string[4] { "HPMHFDGMGGH", "JAGHEMPBMLD", "KAGCEADCKFJ", "Retcode" }, null, null, null, null)
		}));
	}
}
