using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightTutorialSyncInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightTutorialSyncInfoReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "Ch9HcmlkRmlnaHRUdXRvcmlhbFN5bmNJbmZvLnByb3RvGhpHcmlkRmlnaHRD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "dXJyZW50VGFzay5wcm90byKqAQoZR3JpZEZpZ2h0VHV0b3JpYWxTeW5jSW5m";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "bxItCgxjdXJyZW50X3Rhc2sYCSABKAsyFS5HcmlkRmlnaHRDdXJyZW50VGFz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "a0gAEiYKHHN0YXJ0X2dyaWRfZmlnaHRfdHV0b3JpYWxfaWQYCiABKA1IABIn";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "Ch1maW5pc2hfZ3JpZF9maWdodF90dXRvcmlhbF9pZBgLIAEoDUgAQg0KC0tD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "T0NDR0VPRUNPQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { GridFightCurrentTaskReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightTutorialSyncInfo), GridFightTutorialSyncInfo.Parser, new string[3] { "CurrentTask", "StartGridFightTutorialId", "FinishGridFightTutorialId" }, new string[1] { "KCOCCGEOECO" }, null, null, null)
		}));
	}
}
