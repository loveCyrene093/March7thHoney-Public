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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFNS1BEQ0lMRUxBQS5wcm90byKfAQoLTUtQRENJTEVMQUESEwoLTURGT0FE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "TUtKREwYASABKA0SEwoLUERBSUdERk5QUE4YCiABKA0SMgoLQU9NREJETk1C";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "RkMYDiADKAsyHS5NS1BEQ0lMRUxBQS5BT01EQkROTUJGQ0VudHJ5GjIKEEFP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "TURCRE5NQkZDRW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "AUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MKPDCILELAA), MKPDCILELAA.Parser, new string[3] { "MDFOADMKJDL", "PDAIGDFNPPN", "AOMDBDNMBFC" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
