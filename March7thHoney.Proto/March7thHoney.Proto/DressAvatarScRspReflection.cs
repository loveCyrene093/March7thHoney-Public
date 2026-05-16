using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DressAvatarScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DressAvatarScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZEcmVzc0F2YXRhclNjUnNwLnByb3RvIiMKEERyZXNzQXZhdGFyU2NSc3AS" + "DwoHcmV0Y29kZRgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DressAvatarScRsp), DressAvatarScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
