using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeOffEquipmentCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeOffEquipmentCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtUYWtlT2ZmRXF1aXBtZW50Q3NSZXEucHJvdG8iKgoVVGFrZU9mZkVxdWlw" + "bWVudENzUmVxEhEKCWF2YXRhcl9pZBgCIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeOffEquipmentCsReq), TakeOffEquipmentCsReq.Parser, new string[1] { "AvatarId" }, null, null, null, null)
		}));
	}
}
