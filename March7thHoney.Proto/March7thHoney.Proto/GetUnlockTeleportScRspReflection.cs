using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetUnlockTeleportScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetUnlockTeleportScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxHZXRVbmxvY2tUZWxlcG9ydFNjUnNwLnByb3RvIkcKFkdldFVubG9ja1Rl" + "bGVwb3J0U2NSc3ASHAoUdW5sb2NrX3RlbGVwb3J0X2xpc3QYAiADKA0SDwoH" + "cmV0Y29kZRgKIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetUnlockTeleportScRsp), GetUnlockTeleportScRsp.Parser, new string[2] { "UnlockTeleportList", "Retcode" }, null, null, null, null)
		}));
	}
}
