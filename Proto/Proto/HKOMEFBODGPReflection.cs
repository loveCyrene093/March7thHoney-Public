using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HKOMEFBODGPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HKOMEFBODGPReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFIS09NRUZCT0RHUC5wcm90bxoRQ01IQU1CS0NKQksucHJvdG8i1wEKC0hL";
		buffer[1] = "T01FRkJPREdQEiEKC0ZESk1KT0tHT01GGAUgAygLMgwuQ01IQU1CS0NKQksS";
		buffer[2] = "EwoLSUVDTkNKQ0FOT0MYBiADKA0SEwoLSUxFTU1LUEdQTkQYByABKA0SMgoL";
		buffer[3] = "T1BMSkRGT09NR0YYCiADKAsyHS5IS09NRUZCT0RHUC5PUExKREZPT01HRkVu";
		buffer[4] = "dHJ5EhMKC05LR0lHS0VCT0RHGAsgAygNGjIKEE9QTEpERk9PTUdGRW50cnkS";
		buffer[5] = "CwoDa2V5GAEgASgJEg0KBXZhbHVlGAIgASgFOgI4AUIWqgITTWFyY2g3dGhI";
		buffer[6] = "b25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { CMHAMBKCJBKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HKOMEFBODGP), HKOMEFBODGP.Parser, new string[5] { "FDJMJOKGOMF", "IECNCJCANOC", "ILEMMKPGPND", "OPLJDFOOMGF", "NKGIGKEBODG" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
