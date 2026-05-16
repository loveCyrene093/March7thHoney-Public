using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightRefreshShopCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightRefreshShopCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9HcmlkRmlnaHRSZWZyZXNoU2hvcENzUmVxLnByb3RvIhsKGUdyaWRGaWdo" + "dFJlZnJlc2hTaG9wQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightRefreshShopCsReq), GridFightRefreshShopCsReq.Parser, null, null, null, null, null)
		}));
	}
}
