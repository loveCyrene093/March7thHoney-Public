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
		buffer[0] = "CiNHcmlkRmlnaHRDb25zdW1hYmxlVGFyZ2V0SW5mby5wcm90bxohR3JpZEZp";
		buffer[1] = "Z2h0Q29weVR5cGVUYXJnZXRJbmZvLnByb3RvGi9HcmlkRmlnaHRHYWluUmVj";
		buffer[2] = "b21tZW5kRXF1aXBUeXBlVGFyZ2V0SW5mby5wcm90bxojR3JpZEZpZ2h0UmVt";
		buffer[3] = "b3ZlVHlwZVRhcmdldEluZm8ucHJvdG8aIUdyaWRGaWdodFJvbGxUeXBlVGFy";
		buffer[4] = "Z2V0SW5mby5wcm90bxokR3JpZEZpZ2h0VXBncmFkZVR5cGVUYXJnZXRJbmZv";
		buffer[5] = "LnByb3RvIpYDCh1HcmlkRmlnaHRDb25zdW1hYmxlVGFyZ2V0SW5mbxJEChh1";
		buffer[6] = "cGdyYWRlX3R5cGVfdGFyZ2V0X2luZm8YugEgASgLMh8uR3JpZEZpZ2h0VXBn";
		buffer[7] = "cmFkZVR5cGVUYXJnZXRJbmZvSAASPgoVY29weV90eXBlX3RhcmdldF9pbmZv";
		buffer[8] = "GIcDIAEoCzIcLkdyaWRGaWdodENvcHlUeXBlVGFyZ2V0SW5mb0gAElwKJWdh";
		buffer[9] = "aW5fcmVjb21tZW5kX2VxdWlwX3R5cGVfdGFyZ2V0X2luZm8YjgUgASgLMiou";
		buffer[10] = "R3JpZEZpZ2h0R2FpblJlY29tbWVuZEVxdWlwVHlwZVRhcmdldEluZm9IABJC";
		buffer[11] = "ChdyZW1vdmVfdHlwZV90YXJnZXRfaW5mbxicCiABKAsyHi5HcmlkRmlnaHRS";
		buffer[12] = "ZW1vdmVUeXBlVGFyZ2V0SW5mb0gAEj4KFXJvbGxfdHlwZV90YXJnZXRfaW5m";
		buffer[13] = "bxjdCyABKAsyHC5HcmlkRmlnaHRSb2xsVHlwZVRhcmdldEluZm9IAEINCgtI";
		buffer[14] = "REFDQ0lFSUpGT0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[5]
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
