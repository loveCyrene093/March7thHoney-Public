using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DestroyItemCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DestroyItemCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZEZXN0cm95SXRlbUNzUmVxLnByb3RvIkwKEERlc3Ryb3lJdGVtQ3NSZXES" + "EgoKaXRlbV9jb3VudBgIIAEoDRIPCgdpdGVtX2lkGAwgASgNEhMKC1BJQUZD" + "UENEQ0RGGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DestroyItemCsReq), DestroyItemCsReq.Parser, new string[3] { "ItemCount", "ItemId", "PIAFCPCDCDF" }, null, null, null, null)
		}));
	}
}
