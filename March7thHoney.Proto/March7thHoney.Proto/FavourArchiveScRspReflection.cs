using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FavourArchiveScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FavourArchiveScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhGYXZvdXJBcmNoaXZlU2NSc3AucHJvdG8iTwoSRmF2b3VyQXJjaGl2ZVNj" + "UnNwEhMKC0FKTUJPTEhER0hLGAIgASgNEhMKC1BETEJFQ0hESkJMGAcgASgI" + "Eg8KB3JldGNvZGUYDCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FavourArchiveScRsp), FavourArchiveScRsp.Parser, new string[3] { "AJMBOLHDGHK", "PDLBECHDJBL", "Retcode" }, null, null, null, null)
		}));
	}
}
