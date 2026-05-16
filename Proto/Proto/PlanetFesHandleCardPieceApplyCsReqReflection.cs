using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesHandleCardPieceApplyCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesHandleCardPieceApplyCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CihQbGFuZXRGZXNIYW5kbGVDYXJkUGllY2VBcHBseUNzUmVxLnByb3RvIngK";
		buffer[1] = "IlBsYW5ldEZlc0hhbmRsZUNhcmRQaWVjZUFwcGx5Q3NSZXESEwoLSUxDT09G";
		buffer[2] = "TEZHRkgYBCABKAgSEwoLRVBHSUtHQ0FESE0YByABKA0SEwoLR0lJSUdKRk1I";
		buffer[3] = "UE8YCyABKA0SEwoLTUdBRkREQ0dKUE0YDSADKA1CFqoCE01hcmNoN3RoSG9u";
		buffer[4] = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesHandleCardPieceApplyCsReq), PlanetFesHandleCardPieceApplyCsReq.Parser, new string[4] { "ILCOOFLFGFH", "EPGIKGCADHM", "GIIIGJFMHPO", "MGAFDDCGJPM" }, null, null, null, null)
		}));
	}
}
