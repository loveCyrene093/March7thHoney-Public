using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PileItemReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PileItemReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg5QaWxlSXRlbS5wcm90byItCghQaWxlSXRlbRIPCgdpdGVtX2lkGAIgASgN" + "EhAKCGl0ZW1fbnVtGAUgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PileItem), PileItem.Parser, new string[2] { "ItemId", "ItemNum" }, null, null, null, null)
		}));
	}
}
