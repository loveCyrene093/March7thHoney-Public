using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LockEquipmentCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LockEquipmentCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhMb2NrRXF1aXBtZW50Q3NSZXEucHJvdG8iQAoSTG9ja0VxdWlwbWVudENz" + "UmVxEhEKCWlzX2xvY2tlZBgEIAEoCBIXCg9FcXVpcG1lbnRJZExpc3QYDSAD" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LockEquipmentCsReq), LockEquipmentCsReq.Parser, new string[2] { "IsLocked", "EquipmentIdList" }, null, null, null, null)
		}));
	}
}
