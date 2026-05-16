using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UnlockSkillTreeCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UnlockSkillTreeCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpVbmxvY2tTa2lsbFRyZWVDc1JlcS5wcm90bxoOSXRlbUNvc3QucHJvdG8i" + "VQoUVW5sb2NrU2tpbGxUcmVlQ3NSZXESEAoIcG9pbnRfaWQYAiABKA0SHAoJ" + "aXRlbV9saXN0GAcgAygLMgkuSXRlbUNvc3QSDQoFbGV2ZWwYDCABKA1CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { ItemCostReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UnlockSkillTreeCsReq), UnlockSkillTreeCsReq.Parser, new string[3] { "PointId", "ItemList", "Level" }, null, null, null, null)
		}));
	}
}
