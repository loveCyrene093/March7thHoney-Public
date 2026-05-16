using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RelicSmartWearDeletePlanCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RelicSmartWearDeletePlanCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZWxpY1NtYXJ0V2VhckRlbGV0ZVBsYW5Dc1JlcS5wcm90byIyCh1SZWxp" + "Y1NtYXJ0V2VhckRlbGV0ZVBsYW5Dc1JlcRIRCgl1bmlxdWVfaWQYAyABKA1C" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RelicSmartWearDeletePlanCsReq), RelicSmartWearDeletePlanCsReq.Parser, new string[1] { "UniqueId" }, null, null, null, null)
		}));
	}
}
