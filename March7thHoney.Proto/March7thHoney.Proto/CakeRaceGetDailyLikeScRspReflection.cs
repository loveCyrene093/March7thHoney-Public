using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CakeRaceGetDailyLikeScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CakeRaceGetDailyLikeScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9DYWtlUmFjZUdldERhaWx5TGlrZVNjUnNwLnByb3RvIkEKGUNha2VSYWNl" + "R2V0RGFpbHlMaWtlU2NSc3ASEwoLSEZKTkRPQUlET1AYBSADKA0SDwoHcmV0" + "Y29kZRgLIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CakeRaceGetDailyLikeScRsp), CakeRaceGetDailyLikeScRsp.Parser, new string[2] { "HFJNDOAIDOP", "Retcode" }, null, null, null, null)
		}));
	}
}
