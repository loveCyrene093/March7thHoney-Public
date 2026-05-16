using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MDDHDNBEELFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MDDHDNBEELFReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFNRERIRE5CRUVMRi5wcm90bxoRT0RPRkJJSkpOSkcucHJvdG8ivAEKC01E";
		buffer[1] = "REhETkJFRUxGEhMKC0RPQU9QQkJJR1BPGAEgASgNEiEKC0JJQ1BOS09DSEdO";
		buffer[2] = "GAIgAygLMgwuT0RPRkJJSkpOSkcSDQoFbGV2ZWwYAyABKA0SMgoLTk1ITkdJ";
		buffer[3] = "TktPS04YBCADKAsyHS5NRERIRE5CRUVMRi5OTUhOR0lOS09LTkVudHJ5GjIK";
		buffer[4] = "EE5NSE5HSU5LT0tORW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIgASgN";
		buffer[5] = "OgI4AUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ODOFBIJJNJGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MDDHDNBEELF), MDDHDNBEELF.Parser, new string[4] { "DOAOPBBIGPO", "BICPNKOCHGN", "Level", "NMHNGINKOKN" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
