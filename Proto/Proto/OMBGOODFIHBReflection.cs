using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OMBGOODFIHBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OMBGOODFIHBReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFPTUJHT09ERklIQi5wcm90byKlAQoLT01CR09PREZJSEISDwoHcm9vbV9p";
		buffer[1] = "ZBgBIAEoBBITCgtNTUxLRkpJQUtLSBgCIAEoDRITCgtMREtHSkJBTEdLQxgD";
		buffer[2] = "IAEoDRIMCgR0eXBlGAQgASgNEg4KBnJlYXNvbhgFIAEoDRITCgtJRkxMRUtB";
		buffer[3] = "TkRDQhgGIAMoDRITCgtFT09LQ0lMS0tOQhgHIAEoBRITCgtESE5FRUlNTEtF";
		buffer[4] = "ShgIIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OMBGOODFIHB), OMBGOODFIHB.Parser, new string[8] { "RoomId", "MMLKFJIAKKH", "LDKGJBALGKC", "Type", "Reason", "IFLLEKANDCB", "EOOKCILKKNB", "DHNEEIMLKEJ" }, null, null, null, null)
		}));
	}
}
