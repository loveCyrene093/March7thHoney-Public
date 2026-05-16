using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CGDLAIPNECDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CGDLAIPNECDReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFDR0RMQUlQTkVDRC5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvIpIBCgtD";
		buffer[1] = "R0RMQUlQTkVDRBITCgtBTExDQVBBQkhBSBgCIAEoCBITCgtET01HTEhJS0pF";
		buffer[2] = "RBgGIAEoDRIiCgtFSlBMREtGRU1ETRgNIAEoCzINLkl0ZW1Db3N0RGF0YRIg";
		buffer[3] = "Cgljb3N0X2RhdGEYDiABKAsyDS5JdGVtQ29zdERhdGESEwoLS0ZBTUpKR0hK";
		buffer[4] = "T08YDyABKAhCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CGDLAIPNECD), CGDLAIPNECD.Parser, new string[5] { "ALLCAPABHAH", "DOMGLHIKJED", "EJPLDKFEMDM", "CostData", "KFAMJJGHJOO" }, null, null, null, null)
		}));
	}
}
