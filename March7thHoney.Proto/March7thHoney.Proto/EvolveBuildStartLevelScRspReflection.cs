using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EvolveBuildStartLevelScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EvolveBuildStartLevelScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CiBFdm9sdmVCdWlsZFN0YXJ0TGV2ZWxTY1JzcC5wcm90bxoRQ0pMSkRLTENO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "REEucHJvdG8aFVNjZW5lQmF0dGxlSW5mby5wcm90byJ3ChpFdm9sdmVCdWls";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "ZFN0YXJ0TGV2ZWxTY1JzcBIlCgtEREhHQ0FGRkZPUBgEIAEoCzIQLlNjZW5l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "QmF0dGxlSW5mbxIhCgtNT0RESUJIQ1BQRBgLIAEoCzIMLkNKTEpES0xDTkRB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "Eg8KB3JldGNvZGUYDiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			CJLJDKLCNDAReflection.Descriptor,
			SceneBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EvolveBuildStartLevelScRsp), EvolveBuildStartLevelScRsp.Parser, new string[3] { "DDHGCAFFFOP", "MODDIBHCPPD", "Retcode" }, null, null, null, null)
		}));
	}
}
