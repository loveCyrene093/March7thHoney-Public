using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesGiveCardPieceScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesGiveCardPieceScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiFQbGFuZXRGZXNHaXZlQ2FyZFBpZWNlU2NSc3AucHJvdG8iggEKG1BsYW5l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "dEZlc0dpdmVDYXJkUGllY2VTY1JzcBITCgtPTkJCTkFDQkFERhgBIAEoAxIP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "CgdyZXRjb2RlGAMgASgNEhMKC01HQUZERENHSlBNGAUgAygNEhMKC3RlbGVw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "b3J0X2lkGAYgASgNEhMKC1BIQUxLREhIUFBCGA4gASgEQhaqAhNNYXJjaDd0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesGiveCardPieceScRsp), PlanetFesGiveCardPieceScRsp.Parser, new string[5] { "ONBBNACBADF", "Retcode", "MGAFDDCGJPM", "TeleportId", "PHALKDHHPPB" }, null, null, null, null)
		}));
	}
}
