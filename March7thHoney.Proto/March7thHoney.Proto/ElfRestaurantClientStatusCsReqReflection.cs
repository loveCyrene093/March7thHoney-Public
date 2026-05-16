using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ElfRestaurantClientStatusCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ElfRestaurantClientStatusCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRFbGZSZXN0YXVyYW50Q2xpZW50U3RhdHVzQ3NSZXEucHJvdG8iNQoeRWxm" + "UmVzdGF1cmFudENsaWVudFN0YXR1c0NzUmVxEhMKC0hDQkVERUNMQUlDGA4g" + "ASgIQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ElfRestaurantClientStatusCsReq), ElfRestaurantClientStatusCsReq.Parser, new string[1] { "HCBEDECLAIC" }, null, null, null, null)
		}));
	}
}
