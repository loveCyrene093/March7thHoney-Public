using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishCosumeItemMissionCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishCosumeItemMissionCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJGaW5pc2hDb3N1bWVJdGVtTWlzc2lvbkNzUmVxLnByb3RvGg5JdGVtTGlz" + "dC5wcm90byJUChxGaW5pc2hDb3N1bWVJdGVtTWlzc2lvbkNzUmVxEhYKDnN1" + "Yl9taXNzaW9uX2lkGAQgASgNEhwKCWl0ZW1fbGlzdBgNIAEoCzIJLkl0ZW1M" + "aXN0QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishCosumeItemMissionCsReq), FinishCosumeItemMissionCsReq.Parser, new string[2] { "SubMissionId", "ItemList" }, null, null, null, null)
		}));
	}
}
