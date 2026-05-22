using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AnnounceDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AnnounceDataReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChJBbm5vdW5jZURhdGEucHJvdG8i5AEKDEFubm91bmNlRGF0YRIWCg5lbWVy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "Z2VuY3lfdGV4dBgCIAEoCRISCgpiZWdpbl90aW1lGAMgASgDEhMKC01QUERO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "SE5QRkVOGAQgASgNEhEKCWNvbmZpZ19pZBgFIAEoDRIQCghlbmRfdGltZRgG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "IAEoAxITCgtBRURHRU5LSUVQQhgIIAEoCRIYChBiYW5uZXJfZnJlcXVlbmN5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "GAsgASgNEhMKC2Jhbm5lcl90ZXh0GA0gASgJEhUKDWhhc19yZWNvbW1hbmQY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "DiABKAgSEwoLTEhMRUFHQ0pQRkMYDyABKAhCFqoCE01hcmNoN3RoSG9uZXku";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AnnounceData), AnnounceData.Parser, new string[10] { "EmergencyText", "BeginTime", "MPPDNHNPFEN", "ConfigId", "EndTime", "AEDGENKIEPB", "BannerFrequency", "BannerText", "HasRecommand", "LHLEAGCJPFC" }, null, null, null, null)
		}));
	}
}
