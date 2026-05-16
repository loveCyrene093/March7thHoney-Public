using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MKPDCILELAAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MKPDCILELAAReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFNS1BEQ0lMRUxBQS5wcm90byKfAQoLTUtQRENJTEVMQUESEwoLTURGT0FE";
		buffer[1] = "TUtKREwYASABKA0SEwoLUERBSUdERk5QUE4YCiABKA0SMgoLQU9NREJETk1C";
		buffer[2] = "RkMYDiADKAsyHS5NS1BEQ0lMRUxBQS5BT01EQkROTUJGQ0VudHJ5GjIKEEFP";
		buffer[3] = "TURCRE5NQkZDRW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4";
		buffer[4] = "AUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MKPDCILELAA), MKPDCILELAA.Parser, new string[3] { "MDFOADMKJDL", "PDAIGDFNPPN", "AOMDBDNMBFC" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
