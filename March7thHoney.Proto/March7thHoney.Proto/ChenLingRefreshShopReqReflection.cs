using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChenLingRefreshShopReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChenLingRefreshShopReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxDaGVuTGluZ1JlZnJlc2hTaG9wUmVxLnByb3RvIhgKFkNoZW5MaW5nUmVm" + "cmVzaFNob3BSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChenLingRefreshShopReq), ChenLingRefreshShopReq.Parser, null, null, null, null, null)
		}));
	}
}
