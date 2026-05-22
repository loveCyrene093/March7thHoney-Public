using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesGetExtraCardPieceInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesGetExtraCardPieceInfoScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CilQbGFuZXRGZXNHZXRFeHRyYUNhcmRQaWVjZUluZm9TY1JzcC5wcm90bxoR";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "UEVIT0NHSkpNTkYucHJvdG8iWQojUGxhbmV0RmVzR2V0RXh0cmFDYXJkUGll";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "Y2VJbmZvU2NSc3ASIQoLQURKRUVJSUxHQk8YBiABKAsyDC5QRUhPQ0dKSk1O";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "RhIPCgdyZXRjb2RlGAggASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { PEHOCGJJMNFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesGetExtraCardPieceInfoScRsp), PlanetFesGetExtraCardPieceInfoScRsp.Parser, new string[2] { "ADJEEIILGBO", "Retcode" }, null, null, null, null)
		}));
	}
}
