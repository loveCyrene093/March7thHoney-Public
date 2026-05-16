using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AvatarExpUpCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AvatarExpUpCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZBdmF0YXJFeHBVcENzUmVxLnByb3RvGhJJdGVtQ29zdERhdGEucHJvdG8i" + "TAoQQXZhdGFyRXhwVXBDc1JlcRIWCg5iYXNlX2F2YXRhcl9pZBgDIAEoDRIg" + "CglpdGVtX2Nvc3QYCSABKAsyDS5JdGVtQ29zdERhdGFCFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AvatarExpUpCsReq), AvatarExpUpCsReq.Parser, new string[2] { "BaseAvatarId", "ItemCost" }, null, null, null, null)
		}));
	}
}
