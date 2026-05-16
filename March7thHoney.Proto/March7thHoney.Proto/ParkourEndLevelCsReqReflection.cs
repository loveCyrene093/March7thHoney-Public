using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ParkourEndLevelCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ParkourEndLevelCsReqReflection()
	{
		InlineArray10<string> buffer = default(InlineArray10<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 0) = "ChpQYXJrb3VyRW5kTGV2ZWxDc1JlcS5wcm90bxoRQ05OTU1OS0NJSFAucHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 1) = "dG8aEURQQUJBS05KQUhNLnByb3RvGhFHTE9JS0xOSEJMTi5wcm90bxoRTk9N";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 2) = "TkVIQ05HTEgucHJvdG8ijgIKFFBhcmtvdXJFbmRMZXZlbENzUmVxEhMKC0NJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 3) = "RE1ISElDQkpKGAIgASgNEiEKC0pBQ09CQ0xLT09EGAQgAygLMgwuRFBBQkFL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 4) = "TkpBSE0SEwoLSEhQRk5EQkdJSU8YBSABKA0SEAoIbGV2ZWxfaWQYBiABKA0S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 5) = "DAoEdGltZRgHIAEoDRITCgtKRkhLQUNMS0hIQxgIIAEoDRIhCgtIS0NPRkRJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 6) = "TkpJThgMIAEoCzIMLkdMT0lLTE5IQkxOEgwKBHJhbmsYDSABKA0SIAoKZW5k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 7) = "X3JlYXNvbhgOIAEoDjIMLk5PTU5FSENOR0xIEiEKC0lJTUdDSEZGTkxLGA8g";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 8) = "AygLMgwuQ05OTU1OS0NJSFBCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 9) = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray10<string>, string>(in buffer, 10))), new FileDescriptor[4]
		{
			CNNMMNKCIHPReflection.Descriptor,
			DPABAKNJAHMReflection.Descriptor,
			GLOIKLNHBLNReflection.Descriptor,
			NOMNEHCNGLHReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ParkourEndLevelCsReq), ParkourEndLevelCsReq.Parser, new string[10] { "CIDMHHICBJJ", "JACOBCLKOOD", "HHPFNDBGIIO", "LevelId", "Time", "JFHKACLKHHC", "HKCOFDINJIN", "Rank", "EndReason", "IIMGCHFFNLK" }, null, null, null, null)
		}));
	}
}
