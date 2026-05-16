using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerReturnTakePointRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerReturnTakePointRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZQbGF5ZXJSZXR1cm5UYWtlUG9pbnRSZXdhcmRDc1JlcS5wcm90byJMCiBQ" + "bGF5ZXJSZXR1cm5UYWtlUG9pbnRSZXdhcmRDc1JlcRITCgtIREFCTUtDTkpK" + "SxgDIAEoDRITCgtFRElHSkdHUFBPThgLIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerReturnTakePointRewardCsReq), PlayerReturnTakePointRewardCsReq.Parser, new string[2] { "HDABMKCNJJK", "EDIGJGGPPON" }, null, null, null, null)
		}));
	}
}
