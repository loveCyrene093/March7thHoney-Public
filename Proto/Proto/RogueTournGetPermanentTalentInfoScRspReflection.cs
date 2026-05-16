using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournGetPermanentTalentInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournGetPermanentTalentInfoScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CitSb2d1ZVRvdXJuR2V0UGVybWFuZW50VGFsZW50SW5mb1NjUnNwLnByb3Rv";
		buffer[1] = "GhFFQ0pOQUlPTEtKRC5wcm90byJbCiVSb2d1ZVRvdXJuR2V0UGVybWFuZW50";
		buffer[2] = "VGFsZW50SW5mb1NjUnNwEiEKC0ZNS0VGR0pNQ0hBGAUgASgLMgwuRUNKTkFJ";
		buffer[3] = "T0xLSkQSDwoHcmV0Y29kZRgJIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		buffer[4] = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ECJNAIOLKJDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournGetPermanentTalentInfoScRsp), RogueTournGetPermanentTalentInfoScRsp.Parser, new string[2] { "FMKEFGJMCHA", "Retcode" }, null, null, null, null)
		}));
	}
}
