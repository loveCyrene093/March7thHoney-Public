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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFESU1CQUFKTkVBRi5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvIqMBCgtE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "SU1CQUFKTkVBRhIPCgdidWZmX2lkGAEgASgNEhMKC0FMTENBUEFCSEFIGAIg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "ASgIEiAKCWNvc3RfZGF0YRgEIAEoCzINLkl0ZW1Db3N0RGF0YRIiCgtFSlBM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "REtGRU1ETRgFIAEoCzINLkl0ZW1Db3N0RGF0YRITCgtDSFBIQkNPS0NFTxgK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "IAEoDRITCgtLRkFNSkpHSEpPTxgNIAEoCEIWqgITTWFyY2g3dGhIb25leS5Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DIMBAAJNEAF), DIMBAAJNEAF.Parser, new string[6] { "BuffId", "ALLCAPABHAH", "CostData", "EJPLDKFEMDM", "CHPHBCOKCEO", "KFAMJJGHJOO" }, null, null, null, null)
		}));
	}
}
