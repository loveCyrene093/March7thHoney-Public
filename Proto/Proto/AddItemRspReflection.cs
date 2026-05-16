using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AddItemRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AddItemRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChBBZGRJdGVtUnNwLnByb3RvGg5JdGVtTGlzdC5wcm90byJ8CgpBZGRJdGVt";
		buffer[1] = "UnNwEhkKBnJld2FyZBgGIAEoCzIJLkl0ZW1MaXN0EhgKEHVubG9ja190aW1l";
		buffer[2] = "c3RhbXAYDSABKAMSEwoJYXZhdGFyX2lkGAggASgNSAASFQoLRkxFT0NNRUZB";
		buffer[3] = "TkgYCyABKA1IAEINCgtQQU5BSkJIS0FLT0IWqgITTWFyY2g3dGhIb25leS5Q";
		buffer[4] = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AddItemRsp), AddItemRsp.Parser, new string[4] { "Reward", "UnlockTimestamp", "AvatarId", "FLEOCMEFANH" }, new string[1] { "PANAJBHKAKO" }, null, null, null)
		}));
	}
}
