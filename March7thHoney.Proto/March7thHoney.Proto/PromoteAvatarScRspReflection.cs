using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PromoteAvatarScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PromoteAvatarScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhQcm9tb3RlQXZhdGFyU2NSc3AucHJvdG8iJQoSUHJvbW90ZUF2YXRhclNj" + "UnNwEg8KB3JldGNvZGUYBCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PromoteAvatarScRsp), PromoteAvatarScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
