using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EvolveBuildStartStageScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EvolveBuildStartStageScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CiBFdm9sdmVCdWlsZFN0YXJ0U3RhZ2VTY1JzcC5wcm90bxoRQ0pMSkRLTENO";
		buffer[1] = "REEucHJvdG8aFVNjZW5lQmF0dGxlSW5mby5wcm90byJ3ChpFdm9sdmVCdWls";
		buffer[2] = "ZFN0YXJ0U3RhZ2VTY1JzcBIhCgtNT0RESUJIQ1BQRBgFIAEoCzIMLkNKTEpE";
		buffer[3] = "S0xDTkRBEiUKC0RESEdDQUZGRk9QGAYgASgLMhAuU2NlbmVCYXR0bGVJbmZv";
		buffer[4] = "Eg8KB3JldGNvZGUYByABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		buffer[5] = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			CJLJDKLCNDAReflection.Descriptor,
			SceneBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EvolveBuildStartStageScRsp), EvolveBuildStartStageScRsp.Parser, new string[3] { "MODDIBHCPPD", "DDHGCAFFFOP", "Retcode" }, null, null, null, null)
		}));
	}
}
