using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MarkAvatarScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MarkAvatarScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVNYXJrQXZhdGFyU2NSc3AucHJvdG8iSAoPTWFya0F2YXRhclNjUnNwEhEK" + "CWF2YXRhcl9pZBgJIAEoDRIRCglpc19tYXJrZWQYCiABKAgSDwoHcmV0Y29k" + "ZRgLIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MarkAvatarScRsp), MarkAvatarScRsp.Parser, new string[3] { "AvatarId", "IsMarked", "Retcode" }, null, null, null, null)
		}));
	}
}
