using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerLoginFinishScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerLoginFinishScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxQbGF5ZXJMb2dpbkZpbmlzaFNjUnNwLnByb3RvIikKFlBsYXllckxvZ2lu" + "RmluaXNoU2NSc3ASDwoHcmV0Y29kZRgBIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerLoginFinishScRsp), PlayerLoginFinishScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
