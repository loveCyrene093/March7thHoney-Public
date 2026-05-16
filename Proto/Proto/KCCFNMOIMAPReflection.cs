using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KCCFNMOIMAPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KCCFNMOIMAPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLQ0NGTk1PSU1BUC5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvIkwKC0tD" + "Q0ZOTU9JTUFQEiAKCWNvc3RfZGF0YRgGIAEoCzINLkl0ZW1Db3N0RGF0YRIb" + "ChNlcXVpcG1lbnRfdW5pcXVlX2lkGAogASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KCCFNMOIMAP), KCCFNMOIMAP.Parser, new string[2] { "CostData", "EquipmentUniqueId" }, null, null, null, null)
		}));
	}
}
