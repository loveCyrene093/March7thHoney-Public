using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ItemListReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ItemListReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg5JdGVtTGlzdC5wcm90bxoKSXRlbS5wcm90byIkCghJdGVtTGlzdBIYCglp" + "dGVtX2xpc3QYASADKAsyBS5JdGVtQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[1] { ItemReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ItemList), ItemList.Parser, new string[1] { "ItemList_" }, null, null, null, null)
		}));
	}
}
