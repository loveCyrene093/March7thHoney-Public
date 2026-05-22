using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerLoginFinishCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerLoginFinishCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxQbGF5ZXJMb2dpbkZpbmlzaENzUmVxLnByb3RvIhgKFlBsYXllckxvZ2lu" + "RmluaXNoQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerLoginFinishCsReq), PlayerLoginFinishCsReq.Parser, null, null, null, null, null)
		}));
	}
}
