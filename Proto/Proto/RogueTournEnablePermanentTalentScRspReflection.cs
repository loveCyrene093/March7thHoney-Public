using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournEnablePermanentTalentScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournEnablePermanentTalentScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CipSb2d1ZVRvdXJuRW5hYmxlUGVybWFuZW50VGFsZW50U2NSc3AucHJvdG8a";
		buffer[1] = "EUVDSk5BSU9MS0pELnByb3RvIloKJFJvZ3VlVG91cm5FbmFibGVQZXJtYW5l";
		buffer[2] = "bnRUYWxlbnRTY1JzcBIhCgtGTUtFRkdKTUNIQRgBIAEoCzIMLkVDSk5BSU9M";
		buffer[3] = "S0pEEg8KB3JldGNvZGUYCCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		buffer[4] = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ECJNAIOLKJDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournEnablePermanentTalentScRsp), RogueTournEnablePermanentTalentScRsp.Parser, new string[2] { "FMKEFGJMCHA", "Retcode" }, null, null, null, null)
		}));
	}
}
