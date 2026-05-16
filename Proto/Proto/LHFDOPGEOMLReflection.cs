using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LHFDOPGEOMLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LHFDOPGEOMLReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFMSEZET1BHRU9NTC5wcm90byKKAQoLTEhGRE9QR0VPTUwSEwoLQU5MR1BM";
		buffer[1] = "T0xNT0gYAyABKA0SMgoLT0dIR0xNR0pHRU0YBCADKAsyHS5MSEZET1BHRU9N";
		buffer[2] = "TC5PR0hHTE1HSkdFTUVudHJ5GjIKEE9HSEdMTUdKR0VNRW50cnkSCwoDa2V5";
		buffer[3] = "GAEgASgJEg0KBXZhbHVlGAIgASgNOgI4AUIWqgITTWFyY2g3dGhIb25leS5Q";
		buffer[4] = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LHFDOPGEOML), LHFDOPGEOML.Parser, new string[2] { "ANLGPLOLMOH", "OGHGLMGJGEM" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
