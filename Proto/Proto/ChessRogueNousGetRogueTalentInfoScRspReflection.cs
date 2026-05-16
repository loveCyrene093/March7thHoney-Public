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
		buffer[0] = "CitDaGVzc1JvZ3VlTm91c0dldFJvZ3VlVGFsZW50SW5mb1NjUnNwLnByb3Rv";
		buffer[1] = "GhFNQ0FDREZIQ1BJRS5wcm90byJwCiVDaGVzc1JvZ3VlTm91c0dldFJvZ3Vl";
		buffer[2] = "VGFsZW50SW5mb1NjUnNwEhMKC01QR0RKT0dIS0JIGAEgASgNEg8KB3JldGNv";
		buffer[3] = "ZGUYAiABKA0SIQoLdGFsZW50X2luZm8YCSABKAsyDC5NQ0FDREZIQ1BJRUIW";
		buffer[4] = "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MCACDFHCPIEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueNousGetRogueTalentInfoScRsp), ChessRogueNousGetRogueTalentInfoScRsp.Parser, new string[3] { "MPGDJOGHKBH", "Retcode", "TalentInfo" }, null, null, null, null)
		}));
	}
}
