using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IdleLiveGetPendingEquipCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IdleLiveGetPendingEquipCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJJZGxlTGl2ZUdldFBlbmRpbmdFcXVpcENzUmVxLnByb3RvIh4KHElkbGVM" + "aXZlR2V0UGVuZGluZ0VxdWlwQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IdleLiveGetPendingEquipCsReq), IdleLiveGetPendingEquipCsReq.Parser, null, null, null, null, null)
		}));
	}
}
