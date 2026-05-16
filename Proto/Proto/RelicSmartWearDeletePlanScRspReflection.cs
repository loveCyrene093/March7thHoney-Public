using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RelicSmartWearDeletePlanScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RelicSmartWearDeletePlanScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZWxpY1NtYXJ0V2VhckRlbGV0ZVBsYW5TY1JzcC5wcm90byJDCh1SZWxp" + "Y1NtYXJ0V2VhckRlbGV0ZVBsYW5TY1JzcBIPCgdyZXRjb2RlGAwgASgNEhEK" + "CXVuaXF1ZV9pZBgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RelicSmartWearDeletePlanScRsp), RelicSmartWearDeletePlanScRsp.Parser, new string[2] { "Retcode", "UniqueId" }, null, null, null, null)
		}));
	}
}
