using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RemoveStuffFromAreaCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RemoveStuffFromAreaCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5SZW1vdmVTdHVmZkZyb21BcmVhQ3NSZXEucHJvdG8iLwoYUmVtb3ZlU3R1" + "ZmZGcm9tQXJlYUNzUmVxEhMKC0dLRkVHSUJHRUdJGA4gASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RemoveStuffFromAreaCsReq), RemoveStuffFromAreaCsReq.Parser, new string[1] { "GKFEGIBGEGI" }, null, null, null, null)
		}));
	}
}
