using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SyncRogueStatusScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SyncRogueStatusScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1TeW5jUm9ndWVTdGF0dXNTY05vdGlmeS5wcm90bxoRUm9ndWVTdGF0dXMu" + "cHJvdG8iTAoXU3luY1JvZ3VlU3RhdHVzU2NOb3RpZnkSEwoLQ0dOTktHQUFI" + "SU8YCyABKAgSHAoGc3RhdHVzGA4gASgOMgwuUm9ndWVTdGF0dXNCFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { RogueStatusReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SyncRogueStatusScNotify), SyncRogueStatusScNotify.Parser, new string[2] { "CGNNKGAAHIO", "Status" }, null, null, null, null)
		}));
	}
}
