using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetElfRestaurantDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetElfRestaurantDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9HZXRFbGZSZXN0YXVyYW50RGF0YUNzUmVxLnByb3RvIhsKGUdldEVsZlJl" + "c3RhdXJhbnREYXRhQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetElfRestaurantDataCsReq), GetElfRestaurantDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
