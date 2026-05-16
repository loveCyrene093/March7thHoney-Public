using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EAODPIFMANCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EAODPIFMANCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFQU9EUElGTUFOQy5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvIkQKC0VB" + "T0RQSUZNQU5DEiAKCWNvc3RfZGF0YRgEIAEoCzINLkl0ZW1Db3N0RGF0YRIT" + "CgtET0FPUEJCSUdQTxgKIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EAODPIFMANC), EAODPIFMANC.Parser, new string[2] { "CostData", "DOAOPBBIGPO" }, null, null, null, null)
		}));
	}
}
