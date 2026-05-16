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
		buffer[0] = "CilQbGFuZXRGZXNHZXRFeHRyYUNhcmRQaWVjZUluZm9TY1JzcC5wcm90bxoR";
		buffer[1] = "UEVIT0NHSkpNTkYucHJvdG8iWQojUGxhbmV0RmVzR2V0RXh0cmFDYXJkUGll";
		buffer[2] = "Y2VJbmZvU2NSc3ASIQoLQURKRUVJSUxHQk8YBiABKAsyDC5QRUhPQ0dKSk1O";
		buffer[3] = "RhIPCgdyZXRjb2RlGAggASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		buffer[4] = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { PEHOCGJJMNFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesGetExtraCardPieceInfoScRsp), PlanetFesGetExtraCardPieceInfoScRsp.Parser, new string[2] { "ADJEEIILGBO", "Retcode" }, null, null, null, null)
		}));
	}
}
