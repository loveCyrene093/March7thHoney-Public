using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MarbleShopBuyCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MarbleShopBuyCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhNYXJibGVTaG9wQnV5Q3NSZXEucHJvdG8iKQoSTWFyYmxlU2hvcEJ1eUNz" + "UmVxEhMKC05MT0lOTU9EQkxFGAkgAygNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MarbleShopBuyCsReq), MarbleShopBuyCsReq.Parser, new string[1] { "NLOINMODBLE" }, null, null, null, null)
		}));
	}
}
