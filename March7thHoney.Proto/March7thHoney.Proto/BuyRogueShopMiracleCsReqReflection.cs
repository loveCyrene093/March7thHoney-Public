using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BuyRogueShopMiracleCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BuyRogueShopMiracleCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5CdXlSb2d1ZVNob3BNaXJhY2xlQ3NSZXEucHJvdG8iUgoYQnV5Um9ndWVT" + "aG9wTWlyYWNsZUNzUmVxEhMKC0ZHRUtMQk1MSEVLGAQgAygNEiEKGWludGVy" + "YWN0ZWRfcHJvcF9lbnRpdHlfaWQYCSABKA1CFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BuyRogueShopMiracleCsReq), BuyRogueShopMiracleCsReq.Parser, new string[2] { "FGEKLBMLHEK", "InteractedPropEntityId" }, null, null, null, null)
		}));
	}
}
