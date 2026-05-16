using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournGetSeasonTalentInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournGetSeasonTalentInfoScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CihSb2d1ZVRvdXJuR2V0U2Vhc29uVGFsZW50SW5mb1NjUnNwLnByb3RvGhFI";
		buffer[1] = "TEdBTEtBQ0tMSi5wcm90byJYCiJSb2d1ZVRvdXJuR2V0U2Vhc29uVGFsZW50";
		buffer[2] = "SW5mb1NjUnNwEg8KB3JldGNvZGUYCiABKA0SIQoLQk5BSlBQS0ZGQkQYDSAB";
		buffer[3] = "KAsyDC5ITEdBTEtBQ0tMSkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { HLGALKACKLJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournGetSeasonTalentInfoScRsp), RogueTournGetSeasonTalentInfoScRsp.Parser, new string[2] { "Retcode", "BNAJPPKFFBD" }, null, null, null, null)
		}));
	}
}
