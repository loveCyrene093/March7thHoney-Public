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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChxIZWxpb2J1c1N0YXJ0UmFpZENzUmVxLnByb3RvIo4BChZIZWxpb2J1c1N0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "YXJ0UmFpZENzUmVxEg8KB3JhaWRfaWQYBiABKA0SFgoOcHJvcF9lbnRpdHlf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "aWQYCSABKA0SDwoHaXNfc2F2ZRgLIAEoCBIQCghza2lsbF9pZBgNIAEoDRIT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "CgtQS0JBRUJESEZETBgOIAEoDRITCgthdmF0YXJfbGlzdBgPIAMoDUIWqgIT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusStartRaidCsReq), HeliobusStartRaidCsReq.Parser, new string[6] { "RaidId", "PropEntityId", "IsSave", "SkillId", "PKBAEBDHFDL", "AvatarList" }, null, null, null, null)
		}));
	}
}
