using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RelicPresetDeletePlanCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RelicPresetDeletePlanCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZWxpY1ByZXNldERlbGV0ZVBsYW5Dc1JlcS5wcm90byIvChpSZWxpY1By" + "ZXNldERlbGV0ZVBsYW5Dc1JlcRIRCgl1bmlxdWVfaWQYBCABKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RelicPresetDeletePlanCsReq), RelicPresetDeletePlanCsReq.Parser, new string[1] { "UniqueId" }, null, null, null, null)
		}));
	}
}
