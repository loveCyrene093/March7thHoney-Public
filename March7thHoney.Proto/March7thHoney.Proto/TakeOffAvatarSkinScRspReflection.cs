using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeOffAvatarSkinScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeOffAvatarSkinScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxUYWtlT2ZmQXZhdGFyU2tpblNjUnNwLnByb3RvIikKFlRha2VPZmZBdmF0" + "YXJTa2luU2NSc3ASDwoHcmV0Y29kZRgEIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeOffAvatarSkinScRsp), TakeOffAvatarSkinScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
