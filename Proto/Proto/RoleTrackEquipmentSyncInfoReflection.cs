using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RoleTrackEquipmentSyncInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RoleTrackEquipmentSyncInfoReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiBSb2xlVHJhY2tFcXVpcG1lbnRTeW5jSW5mby5wcm90bxocUm9sZVRyYWNr";
		buffer[1] = "RXF1aXBtZW50SW5mby5wcm90byJYChpSb2xlVHJhY2tFcXVpcG1lbnRTeW5j";
		buffer[2] = "SW5mbxI6Chlyb2xlX3RyYWNrX2VxdWlwbWVudF9saXN0GAQgAygLMhcuUm9s";
		buffer[3] = "ZVRyYWNrRXF1aXBtZW50SW5mb0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[4] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { RoleTrackEquipmentInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RoleTrackEquipmentSyncInfo), RoleTrackEquipmentSyncInfo.Parser, new string[1] { "RoleTrackEquipmentList" }, null, null, null, null)
		}));
	}
}
