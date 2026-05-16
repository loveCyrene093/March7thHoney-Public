using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetGunPlayDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetGunPlayDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlHZXRHdW5QbGF5RGF0YVNjUnNwLnByb3RvGhFERU9NTkVPTVBGRS5wcm90" + "byJJChNHZXRHdW5QbGF5RGF0YVNjUnNwEiEKC05CTUFJREVDQ0hKGAUgAygL" + "MgwuREVPTU5FT01QRkUSDwoHcmV0Y29kZRgMIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { DEOMNEOMPFEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetGunPlayDataScRsp), GetGunPlayDataScRsp.Parser, new string[2] { "NBMAIDECCHJ", "Retcode" }, null, null, null, null)
		}));
	}
}
