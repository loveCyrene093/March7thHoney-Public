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
		buffer[0] = "ChJBbm5vdW5jZURhdGEucHJvdG8i5AEKDEFubm91bmNlRGF0YRIWCg5lbWVy";
		buffer[1] = "Z2VuY3lfdGV4dBgCIAEoCRISCgpiZWdpbl90aW1lGAMgASgDEhMKC01QUERO";
		buffer[2] = "SE5QRkVOGAQgASgNEhEKCWNvbmZpZ19pZBgFIAEoDRIQCghlbmRfdGltZRgG";
		buffer[3] = "IAEoAxITCgtBRURHRU5LSUVQQhgIIAEoCRIYChBiYW5uZXJfZnJlcXVlbmN5";
		buffer[4] = "GAsgASgNEhMKC2Jhbm5lcl90ZXh0GA0gASgJEhUKDWhhc19yZWNvbW1hbmQY";
		buffer[5] = "DiABKAgSEwoLTEhMRUFHQ0pQRkMYDyABKAhCFqoCE01hcmNoN3RoSG9uZXku";
		buffer[6] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AnnounceData), AnnounceData.Parser, new string[10] { "EmergencyText", "BeginTime", "MPPDNHNPFEN", "ConfigId", "EndTime", "AEDGENKIEPB", "BannerFrequency", "BannerText", "HasRecommand", "LHLEAGCJPFC" }, null, null, null, null)
		}));
	}
}
