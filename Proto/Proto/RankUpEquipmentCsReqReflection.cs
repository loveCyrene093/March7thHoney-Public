using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RankUpEquipmentCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RankUpEquipmentCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpSYW5rVXBFcXVpcG1lbnRDc1JlcS5wcm90bxoSSXRlbUNvc3REYXRhLnBy" + "b3RvIlUKFFJhbmtVcEVxdWlwbWVudENzUmVxEiAKCWNvc3RfZGF0YRgMIAEo" + "CzINLkl0ZW1Db3N0RGF0YRIbChNlcXVpcG1lbnRfdW5pcXVlX2lkGA8gASgN" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RankUpEquipmentCsReq), RankUpEquipmentCsReq.Parser, new string[2] { "CostData", "EquipmentUniqueId" }, null, null, null, null)
		}));
	}
}
