using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournEnableSeasonTalentScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournEnableSeasonTalentScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CidSb2d1ZVRvdXJuRW5hYmxlU2Vhc29uVGFsZW50U2NSc3AucHJvdG8aEUhM";
		buffer[1] = "R0FMS0FDS0xKLnByb3RvIlcKIVJvZ3VlVG91cm5FbmFibGVTZWFzb25UYWxl";
		buffer[2] = "bnRTY1JzcBIhCgtCTkFKUFBLRkZCRBgHIAEoCzIMLkhMR0FMS0FDS0xKEg8K";
		buffer[3] = "B3JldGNvZGUYCSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[4] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { HLGALKACKLJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournEnableSeasonTalentScRsp), RogueTournEnableSeasonTalentScRsp.Parser, new string[2] { "BNAJPPKFFBD", "Retcode" }, null, null, null, null)
		}));
	}
}
