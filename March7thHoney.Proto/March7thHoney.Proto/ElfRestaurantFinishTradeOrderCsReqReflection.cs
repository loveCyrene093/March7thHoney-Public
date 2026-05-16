using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ElfRestaurantFinishTradeOrderCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ElfRestaurantFinishTradeOrderCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihFbGZSZXN0YXVyYW50RmluaXNoVHJhZGVPcmRlckNzUmVxLnByb3RvIjkK" + "IkVsZlJlc3RhdXJhbnRGaW5pc2hUcmFkZU9yZGVyQ3NSZXESEwoLSUlNS0lG" + "REtKSE8YDCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ElfRestaurantFinishTradeOrderCsReq), ElfRestaurantFinishTradeOrderCsReq.Parser, new string[1] { "IIMKIFDKJHO" }, null, null, null, null)
		}));
	}
}
