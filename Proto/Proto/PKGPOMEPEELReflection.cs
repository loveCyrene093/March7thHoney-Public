using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PKGPOMEPEELReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PKGPOMEPEELReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFQS0dQT01FUEVFTC5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvIpIBCgtQ";
		buffer[1] = "S0dQT01FUEVFTBITCgtBTExDQVBBQkhBSBgDIAEoCBIiCgtFSlBMREtGRU1E";
		buffer[2] = "TRgGIAEoCzINLkl0ZW1Db3N0RGF0YRITCgtJQVBGSklORk5MTxgHIAEoDRIT";
		buffer[3] = "CgtLRkFNSkpHSEpPTxgNIAEoCBIgCgljb3N0X2RhdGEYDiABKAsyDS5JdGVt";
		buffer[4] = "Q29zdERhdGFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PKGPOMEPEEL), PKGPOMEPEEL.Parser, new string[5] { "ALLCAPABHAH", "EJPLDKFEMDM", "IAPFJINFNLO", "KFAMJJGHJOO", "CostData" }, null, null, null, null)
		}));
	}
}
