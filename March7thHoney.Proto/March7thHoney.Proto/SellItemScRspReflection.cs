using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SellItemScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SellItemScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNTZWxsSXRlbVNjUnNwLnByb3RvGg5JdGVtTGlzdC5wcm90byJFCg1TZWxs" + "SXRlbVNjUnNwEg8KB3JldGNvZGUYBSABKA0SIwoQcmV0dXJuX2l0ZW1fbGlz" + "dBgGIAEoCzIJLkl0ZW1MaXN0QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SellItemScRsp), SellItemScRsp.Parser, new string[2] { "Retcode", "ReturnItemList" }, null, null, null, null)
		}));
	}
}
