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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFPTUJHT09ERklIQi5wcm90byKlAQoLT01CR09PREZJSEISDwoHcm9vbV9p";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "ZBgBIAEoBBITCgtNTUxLRkpJQUtLSBgCIAEoDRITCgtMREtHSkJBTEdLQxgD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "IAEoDRIMCgR0eXBlGAQgASgNEg4KBnJlYXNvbhgFIAEoDRITCgtJRkxMRUtB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "TkRDQhgGIAMoDRITCgtFT09LQ0lMS0tOQhgHIAEoBRITCgtESE5FRUlNTEtF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "ShgIIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OMBGOODFIHB), OMBGOODFIHB.Parser, new string[8] { "RoomId", "MMLKFJIAKKH", "LDKGJBALGKC", "Type", "Reason", "IFLLEKANDCB", "EOOKCILKKNB", "DHNEEIMLKEJ" }, null, null, null, null)
		}));
	}
}
