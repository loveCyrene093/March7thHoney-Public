using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueNousGetRogueTalentInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueNousGetRogueTalentInfoScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CitDaGVzc1JvZ3VlTm91c0dldFJvZ3VlVGFsZW50SW5mb1NjUnNwLnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "GhFNQ0FDREZIQ1BJRS5wcm90byJwCiVDaGVzc1JvZ3VlTm91c0dldFJvZ3Vl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "VGFsZW50SW5mb1NjUnNwEhMKC01QR0RKT0dIS0JIGAEgASgNEg8KB3JldGNv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "ZGUYAiABKA0SIQoLdGFsZW50X2luZm8YCSABKAsyDC5NQ0FDREZIQ1BJRUIW";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { MCACDFHCPIEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueNousGetRogueTalentInfoScRsp), ChessRogueNousGetRogueTalentInfoScRsp.Parser, new string[3] { "MPGDJOGHKBH", "Retcode", "TalentInfo" }, null, null, null, null)
		}));
	}
}
