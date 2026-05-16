using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GachaItemReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GachaItemReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Cg9HYWNoYUl0ZW0ucHJvdG8aCkl0ZW0ucHJvdG8aDkl0ZW1MaXN0LnByb3Rv";
		buffer[1] = "InwKCUdhY2hhSXRlbRIOCgZpc19uZXcYBiABKAgSHQoKdG9rZW5faXRlbRgH";
		buffer[2] = "IAEoCzIJLkl0ZW1MaXN0EiUKEnRyYW5zZmVyX2l0ZW1fbGlzdBgMIAEoCzIJ";
		buffer[3] = "Lkl0ZW1MaXN0EhkKCmdhY2hhX2l0ZW0YDSABKAsyBS5JdGVtQhaqAhNNYXJj";
		buffer[4] = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ItemReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GachaItem), GachaItem.Parser, new string[4] { "IsNew", "TokenItem", "TransferItemList", "GachaItem_" }, null, null, null, null)
		}));
	}
}
