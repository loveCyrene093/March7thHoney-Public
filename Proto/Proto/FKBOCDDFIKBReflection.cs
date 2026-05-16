using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FKBOCDDFIKBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FKBOCDDFIKBReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFGS0JPQ0RERklLQi5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvIsEBCgtG";
		buffer[1] = "S0JPQ0RERklLQhIgCgljb3N0X2RhdGEYASABKAsyDS5JdGVtQ29zdERhdGES";
		buffer[2] = "EwoLUElHRElGQUtJR00YBCABKAUSMgoLR0hHSkxGR09PRUwYCiADKAsyHS5G";
		buffer[3] = "S0JPQ0RERklLQi5HSEdKTEZHT09FTEVudHJ5EhMKC0pLSU1MSVBNS0ZIGAwg";
		buffer[4] = "ASgNGjIKEEdIR0pMRkdPT0VMRW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVl";
		buffer[5] = "GAIgASgIOgI4AUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FKBOCDDFIKB), FKBOCDDFIKB.Parser, new string[4] { "CostData", "PIGDIFAKIGM", "GHGJLFGOOEL", "JKIMLIPMKFH" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
