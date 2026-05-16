using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetMultipleAvatarPathsScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetMultipleAvatarPathsScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFTZXRNdWx0aXBsZUF2YXRhclBhdGhzU2NSc3AucHJvdG8iLgobU2V0TXVs" + "dGlwbGVBdmF0YXJQYXRoc1NjUnNwEg8KB3JldGNvZGUYDyABKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetMultipleAvatarPathsScRsp), SetMultipleAvatarPathsScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
