using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterElfRestaurantNextDayCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterElfRestaurantNextDayCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRFbnRlckVsZlJlc3RhdXJhbnROZXh0RGF5Q3NSZXEucHJvdG8iIAoeRW50" + "ZXJFbGZSZXN0YXVyYW50TmV4dERheUNzUmVxQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterElfRestaurantNextDayCsReq), EnterElfRestaurantNextDayCsReq.Parser, null, null, null, null, null)
		}));
	}
}
