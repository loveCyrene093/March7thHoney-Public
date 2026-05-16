using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DIMBAAJNEAFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DIMBAAJNEAFReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFESU1CQUFKTkVBRi5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvIqMBCgtE";
		buffer[1] = "SU1CQUFKTkVBRhIPCgdidWZmX2lkGAEgASgNEhMKC0FMTENBUEFCSEFIGAIg";
		buffer[2] = "ASgIEiAKCWNvc3RfZGF0YRgEIAEoCzINLkl0ZW1Db3N0RGF0YRIiCgtFSlBM";
		buffer[3] = "REtGRU1ETRgFIAEoCzINLkl0ZW1Db3N0RGF0YRITCgtDSFBIQkNPS0NFTxgK";
		buffer[4] = "IAEoDRITCgtLRkFNSkpHSEpPTxgNIAEoCEIWqgITTWFyY2g3dGhIb25leS5Q";
		buffer[5] = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DIMBAAJNEAF), DIMBAAJNEAF.Parser, new string[6] { "BuffId", "ALLCAPABHAH", "CostData", "EJPLDKFEMDM", "CHPHBCOKCEO", "KFAMJJGHJOO" }, null, null, null, null)
		}));
	}
}
