using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RelicListReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RelicListReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg9SZWxpY0xpc3QucHJvdG8iKQoJUmVsaWNMaXN0Eg4KBnNldF9pZBgJIAEo" + "DRIMCgR0eXBlGAwgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RelicList), RelicList.Parser, new string[2] { "SetId", "Type" }, null, null, null, null)
		}));
	}
}
