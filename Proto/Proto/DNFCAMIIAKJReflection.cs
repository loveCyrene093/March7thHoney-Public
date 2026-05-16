using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DNFCAMIIAKJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DNFCAMIIAKJReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFETkZDQU1JSUFLSi5wcm90byKKAQoLRE5GQ0FNSUlBS0oSEwoLQ0FCRUlG";
		buffer[1] = "SEtHQkcYCSADKA0SMgoLUEROQ0xQRURKSUYYCiADKAsyHS5ETkZDQU1JSUFL";
		buffer[2] = "Si5QRE5DTFBFREpJRkVudHJ5GjIKEFBETkNMUEVESklGRW50cnkSCwoDa2V5";
		buffer[3] = "GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4AUIWqgITTWFyY2g3dGhIb25leS5Q";
		buffer[4] = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DNFCAMIIAKJ), DNFCAMIIAKJ.Parser, new string[2] { "CABEIFHKGBG", "PDNCLPEDJIF" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
