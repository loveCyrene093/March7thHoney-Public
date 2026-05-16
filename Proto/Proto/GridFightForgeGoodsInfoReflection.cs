using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightForgeGoodsInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightForgeGoodsInfoReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "Ch1HcmlkRmlnaHRGb3JnZUdvb2RzSW5mby5wcm90bxohR3JpZEZpZ2h0Rm9y";
		buffer[1] = "Z2VFcXVpcG1lbnRJbmZvLnByb3RvGhxHcmlkRmlnaHRGb3JnZVJvbGVJbmZv";
		buffer[2] = "LnByb3RvIpoBChdHcmlkRmlnaHRGb3JnZUdvb2RzSW5mbxIyCg9yb2xlX2dv";
		buffer[3] = "b2RzX2luZm8YAyABKAsyFy5HcmlkRmlnaHRGb3JnZVJvbGVJbmZvSAASPAoU";
		buffer[4] = "ZXF1aXBtZW50X2dvb2RzX2luZm8YCSABKAsyHC5HcmlkRmlnaHRGb3JnZUVx";
		buffer[5] = "dWlwbWVudEluZm9IAEINCgtDS01FQUlES09JQUIWqgITTWFyY2g3dGhIb25l";
		buffer[6] = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			GridFightForgeEquipmentInfoReflection.Descriptor,
			GridFightForgeRoleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightForgeGoodsInfo), GridFightForgeGoodsInfo.Parser, new string[2] { "RoleGoodsInfo", "EquipmentGoodsInfo" }, new string[1] { "CKMEAIDKOIA" }, null, null, null)
		}));
	}
}
