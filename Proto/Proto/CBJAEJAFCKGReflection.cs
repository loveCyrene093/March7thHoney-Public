using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CBJAEJAFCKGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CBJAEJAFCKGReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFDQkpBRUpBRkNLRy5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvIsQBCgtD";
		buffer[1] = "QkpBRUpBRkNLRxITCgtPRkhDTkdISkZISRgBIAEoDRITCgtPS09CR0ZIR0lK";
		buffer[2] = "QhgCIAEoDRIiCgtFQ0JJTFBQTEZJSRgFIAEoCzINLkl0ZW1Db3N0RGF0YRIT";
		buffer[3] = "CgtERUZESkpQTEJQRxgGIAMoDRITCgtPSkFQTU5BUElGRxgHIAEoCBITCgtG";
		buffer[4] = "QkRLREVCSkZHQhgJIAEoDRITCgtIRlBHTUJBS0JNQhgOIAEoDRITCgtET0pO";
		buffer[5] = "SUhHSURLRRgPIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CBJAEJAFCKG), CBJAEJAFCKG.Parser, new string[8] { "OFHCNGHJFHI", "OKOBGFHGIJB", "ECBILPPLFII", "DEFDJJPLBPG", "OJAPMNAPIFG", "FBDKDEBJFGB", "HFPGMBAKBMB", "DOJNIHGIDKE" }, null, null, null, null)
		}));
	}
}
