using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AddEquipmentScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AddEquipmentScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdBZGRFcXVpcG1lbnRTY1JzcC5wcm90byIoChFBZGRFcXVpcG1lbnRTY1Jz" + "cBITCgtIT0tKRktOUEtBShgHIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AddEquipmentScRsp), AddEquipmentScRsp.Parser, new string[1] { "HOKJFKNPKAJ" }, null, null, null, null)
		}));
	}
}
