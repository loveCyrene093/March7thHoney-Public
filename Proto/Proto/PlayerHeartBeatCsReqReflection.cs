using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerHeartBeatCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerHeartBeatCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpQbGF5ZXJIZWFydEJlYXRDc1JlcS5wcm90bxoRRE9ERUxFQUlDR0kucHJv" + "dG8iYgoUUGxheWVySGVhcnRCZWF0Q3NSZXESFgoOY2xpZW50X3RpbWVfbXMY" + "AyABKAQSEwoLS0tDRENJSkhKRkEYCSABKA0SHQoHc2NfZGF0YRgLIAEoCzIM" + "LkRPREVMRUFJQ0dJQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { DODELEAICGIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerHeartBeatCsReq), PlayerHeartBeatCsReq.Parser, new string[3] { "ClientTimeMs", "KKCDCIJHJFA", "ScData" }, null, null, null, null)
		}));
	}
}
