using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraDuelUnlockMasterScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraDuelUnlockMasterScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJDaGltZXJhRHVlbFVubG9ja01hc3RlclNjUnNwLnByb3RvIkQKHENoaW1l" + "cmFEdWVsVW5sb2NrTWFzdGVyU2NSc3ASDwoHcmV0Y29kZRgCIAEoDRITCgtP" + "RkZJRE1FSkJHSRgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraDuelUnlockMasterScRsp), ChimeraDuelUnlockMasterScRsp.Parser, new string[2] { "Retcode", "OFFIDMEJBGI" }, null, null, null, null)
		}));
	}
}
