using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DisplayRelicInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DisplayRelicInfoReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChZEaXNwbGF5UmVsaWNJbmZvLnByb3RvGhBSZWxpY0FmZml4LnByb3RvIoUB";
		buffer[1] = "ChBEaXNwbGF5UmVsaWNJbmZvEg0KBWxldmVsGAIgASgNEgsKA2V4cBgDIAEo";
		buffer[2] = "DRIVCg1tYWluX2FmZml4X2lkGAUgASgNEgsKA3RpZBgHIAEoDRIjCg5zdWJf";
		buffer[3] = "YWZmaXhfbGlzdBgNIAMoCzILLlJlbGljQWZmaXgSDAoEdHlwZRgPIAEoDUIW";
		buffer[4] = "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { RelicAffixReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DisplayRelicInfo), DisplayRelicInfo.Parser, new string[6] { "Level", "Exp", "MainAffixId", "Tid", "SubAffixList", "Type" }, null, null, null, null)
		}));
	}
}
