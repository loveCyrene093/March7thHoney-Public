using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ExpUpEquipmentCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ExpUpEquipmentCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlFeHBVcEVxdWlwbWVudENzUmVxLnByb3RvGhJJdGVtQ29zdERhdGEucHJv" + "dG8iVAoTRXhwVXBFcXVpcG1lbnRDc1JlcRIbChNlcXVpcG1lbnRfdW5pcXVl" + "X2lkGAkgASgNEiAKCWNvc3RfZGF0YRgKIAEoCzINLkl0ZW1Db3N0RGF0YUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ExpUpEquipmentCsReq), ExpUpEquipmentCsReq.Parser, new string[2] { "EquipmentUniqueId", "CostData" }, null, null, null, null)
		}));
	}
}
