using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightConsumableTargetInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightConsumableTargetInfoReflection()
	{
		InlineArray15<string> buffer = default(InlineArray15<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 0) = "CiNHcmlkRmlnaHRDb25zdW1hYmxlVGFyZ2V0SW5mby5wcm90bxohR3JpZEZp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 1) = "Z2h0Q29weVR5cGVUYXJnZXRJbmZvLnByb3RvGi9HcmlkRmlnaHRHYWluUmVj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 2) = "b21tZW5kRXF1aXBUeXBlVGFyZ2V0SW5mby5wcm90bxojR3JpZEZpZ2h0UmVt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 3) = "b3ZlVHlwZVRhcmdldEluZm8ucHJvdG8aIUdyaWRGaWdodFJvbGxUeXBlVGFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 4) = "Z2V0SW5mby5wcm90bxokR3JpZEZpZ2h0VXBncmFkZVR5cGVUYXJnZXRJbmZv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 5) = "LnByb3RvIpYDCh1HcmlkRmlnaHRDb25zdW1hYmxlVGFyZ2V0SW5mbxJEChh1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 6) = "cGdyYWRlX3R5cGVfdGFyZ2V0X2luZm8YugEgASgLMh8uR3JpZEZpZ2h0VXBn";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 7) = "cmFkZVR5cGVUYXJnZXRJbmZvSAASPgoVY29weV90eXBlX3RhcmdldF9pbmZv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 8) = "GIcDIAEoCzIcLkdyaWRGaWdodENvcHlUeXBlVGFyZ2V0SW5mb0gAElwKJWdh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 9) = "aW5fcmVjb21tZW5kX2VxdWlwX3R5cGVfdGFyZ2V0X2luZm8YjgUgASgLMiou";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 10) = "R3JpZEZpZ2h0R2FpblJlY29tbWVuZEVxdWlwVHlwZVRhcmdldEluZm9IABJC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 11) = "ChdyZW1vdmVfdHlwZV90YXJnZXRfaW5mbxicCiABKAsyHi5HcmlkRmlnaHRS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 12) = "ZW1vdmVUeXBlVGFyZ2V0SW5mb0gAEj4KFXJvbGxfdHlwZV90YXJnZXRfaW5m";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 13) = "bxjdCyABKAsyHC5HcmlkRmlnaHRSb2xsVHlwZVRhcmdldEluZm9IAEINCgtI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 14) = "REFDQ0lFSUpGT0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray15<string>, string>(in buffer, 15))), new FileDescriptor[5]
		{
			GridFightCopyTypeTargetInfoReflection.Descriptor,
			GridFightGainRecommendEquipTypeTargetInfoReflection.Descriptor,
			GridFightRemoveTypeTargetInfoReflection.Descriptor,
			GridFightRollTypeTargetInfoReflection.Descriptor,
			GridFightUpgradeTypeTargetInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightConsumableTargetInfo), GridFightConsumableTargetInfo.Parser, new string[5] { "UpgradeTypeTargetInfo", "CopyTypeTargetInfo", "GainRecommendEquipTypeTargetInfo", "RemoveTypeTargetInfo", "RollTypeTargetInfo" }, new string[1] { "HDACCIEIJFO" }, null, null, null)
		}));
	}
}
