using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HCIGONGJHEJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HCIGONGJHEJReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFIQ0lHT05HSkhFSi5wcm90byKZAQoLSENJR09OR0pIRUoSEwoLRVBEQUZJ";
		buffer[1] = "Q01KQU8YASABKA0SEwoLSkRMQk1GTkhCSUkYAiABKAESEwoLSEpMT0xDR0lM";
		buffer[2] = "SkwYAyABKAESDAoEd2F2ZRgEIAEoDRITCgtJQkZCR0VGTE9KSxgFIAEoDRIT";
		buffer[3] = "CgtNRUNIRE9IRE5GUBgGIAEoARITCgtLQUVNRkVHSkdNUBgHIAEoAUIWqgIT";
		buffer[4] = "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HCIGONGJHEJ), HCIGONGJHEJ.Parser, new string[7] { "EPDAFICMJAO", "JDLBMFNHBII", "HJLOLCGILJL", "Wave", "IBFBGEFLOJK", "MECHDOHDNFP", "KAEMFEGJGMP" }, null, null, null, null)
		}));
	}
}
