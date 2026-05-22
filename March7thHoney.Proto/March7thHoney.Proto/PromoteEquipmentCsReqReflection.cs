using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PromoteEquipmentCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PromoteEquipmentCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtQcm9tb3RlRXF1aXBtZW50Q3NSZXEucHJvdG8aEkl0ZW1Db3N0RGF0YS5w" + "cm90byJWChVQcm9tb3RlRXF1aXBtZW50Q3NSZXESIAoJY29zdF9kYXRhGAUg" + "ASgLMg0uSXRlbUNvc3REYXRhEhsKE2VxdWlwbWVudF91bmlxdWVfaWQYDSAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PromoteEquipmentCsReq), PromoteEquipmentCsReq.Parser, new string[2] { "CostData", "EquipmentUniqueId" }, null, null, null, null)
		}));
	}
}
