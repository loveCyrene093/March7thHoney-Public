using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwitchHandDataNodeSnapshotReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwitchHandDataNodeSnapshotReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CiBTd2l0Y2hIYW5kRGF0YU5vZGVTbmFwc2hvdC5wcm90bxoYTW90aW9uSW5m";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "b1NuYXBzaG90LnByb3RvIpwBChpTd2l0Y2hIYW5kRGF0YU5vZGVTbmFwc2hv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "dBIRCgljb25maWdfaWQYASABKA0SKwoOaGFuZF90cmFuc2Zvcm0YAiABKAsy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "Ey5Nb3Rpb25JbmZvU25hcHNob3QSEgoKaGFuZF9zdGF0ZRgDIAEoDRISCgpo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "YW5kX3BhcmFtGAQgASgMEhYKDmdldF9jb2luX2NvdW50GAUgASgNQhaqAhNN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { MotionInfoSnapshotReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwitchHandDataNodeSnapshot), SwitchHandDataNodeSnapshot.Parser, new string[5] { "ConfigId", "HandTransform", "HandState", "HandParam", "GetCoinCount" }, null, null, null, null)
		}));
	}
}
