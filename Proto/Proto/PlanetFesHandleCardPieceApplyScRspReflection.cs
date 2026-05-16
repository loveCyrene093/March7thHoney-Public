using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesHandleCardPieceApplyScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesHandleCardPieceApplyScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CihQbGFuZXRGZXNIYW5kbGVDYXJkUGllY2VBcHBseVNjUnNwLnByb3RvIokB";
		buffer[1] = "CiJQbGFuZXRGZXNIYW5kbGVDYXJkUGllY2VBcHBseVNjUnNwEhMKC01HQUZE";
		buffer[2] = "RENHSlBNGAQgAygNEhMKC0lMQ09PRkxGR0ZIGAYgASgIEhMKC0VQR0lLR0NB";
		buffer[3] = "REhNGAggASgNEg8KB3JldGNvZGUYDiABKA0SEwoLT05CQk5BQ0JBREYYDyAB";
		buffer[4] = "KANCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesHandleCardPieceApplyScRsp), PlanetFesHandleCardPieceApplyScRsp.Parser, new string[5] { "MGAFDDCGJPM", "ILCOOFLFGFH", "EPGIKGCADHM", "Retcode", "ONBBNACBADF" }, null, null, null, null)
		}));
	}
}
