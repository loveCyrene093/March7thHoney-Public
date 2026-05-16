using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournGetCurRogueCocoonInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournGetCurRogueCocoonInfoScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CipSb2d1ZVRvdXJuR2V0Q3VyUm9ndWVDb2Nvb25JbmZvU2NSc3AucHJvdG8i";
		buffer[1] = "igEKJFJvZ3VlVG91cm5HZXRDdXJSb2d1ZUNvY29vbkluZm9TY1JzcBINCgVD";
		buffer[2] = "b3VudBgDIAEoDRITCgtMSlBMSUhFUEdIQRgEIAEoDRIYChBkaWZmaWN1bHR5";
		buffer[3] = "X2xldmVsGAUgASgNEhMKC0pPTUhFSUhMTERNGAkgASgNEg8KB3JldGNvZGUY";
		buffer[4] = "CiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournGetCurRogueCocoonInfoScRsp), RogueTournGetCurRogueCocoonInfoScRsp.Parser, new string[5] { "Count", "LJPLIHEPGHA", "DifficultyLevel", "JOMHEIHLLDM", "Retcode" }, null, null, null, null)
		}));
	}
}
