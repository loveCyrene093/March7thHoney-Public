using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAuthkeyScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAuthkeyScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVHZXRBdXRoa2V5U2NSc3AucHJvdG8ibwoPR2V0QXV0aGtleVNjUnNwEg8K" + "B3JldGNvZGUYASABKA0SEgoKYXV0aF9hcHBpZBgEIAEoCRIRCglzaWduX3R5" + "cGUYByABKA0SDwoHYXV0aGtleRgKIAEoCRITCgthdXRoa2V5X3ZlchgOIAEo" + "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAuthkeyScRsp), GetAuthkeyScRsp.Parser, new string[5] { "Retcode", "AuthAppid", "SignType", "Authkey", "AuthkeyVer" }, null, null, null, null)
		}));
	}
}
