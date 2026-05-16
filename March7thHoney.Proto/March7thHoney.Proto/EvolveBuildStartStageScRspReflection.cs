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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CiBFdm9sdmVCdWlsZFN0YXJ0U3RhZ2VTY1JzcC5wcm90bxoRQ0pMSkRLTENO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "REEucHJvdG8aFVNjZW5lQmF0dGxlSW5mby5wcm90byJ3ChpFdm9sdmVCdWls";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "ZFN0YXJ0U3RhZ2VTY1JzcBIhCgtNT0RESUJIQ1BQRBgFIAEoCzIMLkNKTEpE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "S0xDTkRBEiUKC0RESEdDQUZGRk9QGAYgASgLMhAuU2NlbmVCYXR0bGVJbmZv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "Eg8KB3JldGNvZGUYByABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			CJLJDKLCNDAReflection.Descriptor,
			SceneBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EvolveBuildStartStageScRsp), EvolveBuildStartStageScRsp.Parser, new string[3] { "MODDIBHCPPD", "DDHGCAFFFOP", "Retcode" }, null, null, null, null)
		}));
	}
}
