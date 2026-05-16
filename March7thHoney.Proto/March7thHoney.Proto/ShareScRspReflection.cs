using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ShareScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ShareScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChBTaGFyZVNjUnNwLnByb3RvGg5JdGVtTGlzdC5wcm90bxoRTEhNSEZOQk9B" + "R0MucHJvdG8iWwoKU2hhcmVTY1JzcBIhCgtDQ0RBTUpLQkNHQxgDIAEoCzIM" + "LkxITUhGTkJPQUdDEhkKBnJld2FyZBgNIAEoCzIJLkl0ZW1MaXN0Eg8KB3Jl" + "dGNvZGUYDiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[2]
		{
			ItemListReflection.Descriptor,
			LHMHFNBOAGCReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ShareScRsp), ShareScRsp.Parser, new string[3] { "CCDAMJKBCGC", "Reward", "Retcode" }, null, null, null, null)
		}));
	}
}
