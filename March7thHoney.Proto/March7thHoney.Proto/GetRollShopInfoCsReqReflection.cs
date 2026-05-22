using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRollShopInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRollShopInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpHZXRSb2xsU2hvcEluZm9Dc1JlcS5wcm90byIsChRHZXRSb2xsU2hvcElu" + "Zm9Dc1JlcRIUCgxyb2xsX3Nob3BfaWQYCyABKA1CFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRollShopInfoCsReq), GetRollShopInfoCsReq.Parser, new string[1] { "RollShopId" }, null, null, null, null)
		}));
	}
}
