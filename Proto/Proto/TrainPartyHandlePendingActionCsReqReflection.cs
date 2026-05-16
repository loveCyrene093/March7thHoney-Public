using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainPartyHandlePendingActionCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainPartyHandlePendingActionCsReqReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "CihUcmFpblBhcnR5SGFuZGxlUGVuZGluZ0FjdGlvbkNzUmVxLnByb3RvGhFC";
		buffer[1] = "Sk9CRElITkxQSy5wcm90bxoRQk9DTkNKQU5CT00ucHJvdG8aEUNEQUFPSkZN";
		buffer[2] = "QUxPLnByb3RvGhFITEpMR1BJRk1KRC5wcm90byLiAQoiVHJhaW5QYXJ0eUhh";
		buffer[3] = "bmRsZVBlbmRpbmdBY3Rpb25Dc1JlcRIWCg5xdWV1ZV9wb3NpdGlvbhgGIAEo";
		buffer[4] = "DRIjCgtNQk9HTlBLQU1JRhhWIAEoCzIMLkhMSkxHUElGTUpESAASJAoLTkpD";
		buffer[5] = "SEpQUEZBSk8YtgggASgLMgwuQkpPQkRJSE5MUEtIABIkCgtESkdBUEZQSEZJ";
		buffer[6] = "SRihCSABKAsyDC5DREFBT0pGTUFMT0gAEiQKC0hCS0dKT0FQT0tCGMEMIAEo";
		buffer[7] = "CzIMLkJPQ05DSkFOQk9NSABCDQoLUE5LUENQRkJIQUFCFqoCE01hcmNoN3Ro";
		buffer[8] = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
		{
			BJOBDIHNLPKReflection.Descriptor,
			BOCNCJANBOMReflection.Descriptor,
			CDAAOJFMALOReflection.Descriptor,
			HLJLGPIFMJDReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainPartyHandlePendingActionCsReq), TrainPartyHandlePendingActionCsReq.Parser, new string[5] { "QueuePosition", "MBOGNPKAMIF", "NJCHJPPFAJO", "DJGAPFPHFII", "HBKGJOAPOKB" }, new string[1] { "PNKPCPFBHAA" }, null, null, null)
		}));
	}
}
