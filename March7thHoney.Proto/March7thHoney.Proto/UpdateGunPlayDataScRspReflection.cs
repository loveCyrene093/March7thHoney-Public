using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpdateGunPlayDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpdateGunPlayDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxVcGRhdGVHdW5QbGF5RGF0YVNjUnNwLnByb3RvGhFERU9NTkVPTVBGRS5w" + "cm90byJMChZVcGRhdGVHdW5QbGF5RGF0YVNjUnNwEiEKC0RJRkxLSE1LSEJH" + "GAEgASgLMgwuREVPTU5FT01QRkUSDwoHcmV0Y29kZRgFIAEoDUIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { DEOMNEOMPFEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpdateGunPlayDataScRsp), UpdateGunPlayDataScRsp.Parser, new string[2] { "DIFLKHMKHBG", "Retcode" }, null, null, null, null)
		}));
	}
}
