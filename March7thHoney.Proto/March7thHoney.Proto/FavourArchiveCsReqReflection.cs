using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FavourArchiveCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FavourArchiveCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhGYXZvdXJBcmNoaXZlQ3NSZXEucHJvdG8iPgoSRmF2b3VyQXJjaGl2ZUNz" + "UmVxEhMKC1BETEJFQ0hESkJMGAQgASgIEhMKC0FKTUJPTEhER0hLGAwgASgN" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FavourArchiveCsReq), FavourArchiveCsReq.Parser, new string[2] { "PDLBECHDJBL", "AJMBOLHDGHK" }, null, null, null, null)
		}));
	}
}
