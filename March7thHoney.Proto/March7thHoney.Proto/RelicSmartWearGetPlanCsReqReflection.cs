using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RelicSmartWearGetPlanCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RelicSmartWearGetPlanCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZWxpY1NtYXJ0V2VhckdldFBsYW5Dc1JlcS5wcm90byIvChpSZWxpY1Nt" + "YXJ0V2VhckdldFBsYW5Dc1JlcRIRCglhdmF0YXJfaWQYBCABKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RelicSmartWearGetPlanCsReq), RelicSmartWearGetPlanCsReq.Parser, new string[1] { "AvatarId" }, null, null, null, null)
		}));
	}
}
