using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ComposeItemCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ComposeItemCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChZDb21wb3NlSXRlbUNzUmVxLnByb3RvGhJJdGVtQ29zdERhdGEucHJvdG8i";
		buffer[1] = "iQEKEENvbXBvc2VJdGVtQ3NSZXESEgoKY29tcG9zZV9pZBgGIAEoDRIoChFj";
		buffer[2] = "b21wb3NlX2l0ZW1fbGlzdBgKIAEoCzINLkl0ZW1Db3N0RGF0YRINCgVjb3Vu";
		buffer[3] = "dBgMIAEoDRIoChFjb252ZXJ0X2l0ZW1fbGlzdBgNIAEoCzINLkl0ZW1Db3N0";
		buffer[4] = "RGF0YUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ComposeItemCsReq), ComposeItemCsReq.Parser, new string[4] { "ComposeId", "ComposeItemList", "Count", "ConvertItemList" }, null, null, null, null)
		}));
	}
}
