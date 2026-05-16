using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeliobusStartRaidCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeliobusStartRaidCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChxIZWxpb2J1c1N0YXJ0UmFpZENzUmVxLnByb3RvIo4BChZIZWxpb2J1c1N0";
		buffer[1] = "YXJ0UmFpZENzUmVxEg8KB3JhaWRfaWQYBiABKA0SFgoOcHJvcF9lbnRpdHlf";
		buffer[2] = "aWQYCSABKA0SDwoHaXNfc2F2ZRgLIAEoCBIQCghza2lsbF9pZBgNIAEoDRIT";
		buffer[3] = "CgtQS0JBRUJESEZETBgOIAEoDRITCgthdmF0YXJfbGlzdBgPIAMoDUIWqgIT";
		buffer[4] = "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusStartRaidCsReq), HeliobusStartRaidCsReq.Parser, new string[6] { "RaidId", "PropEntityId", "IsSave", "SkillId", "PKBAEBDHFDL", "AvatarList" }, null, null, null, null)
		}));
	}
}
