using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetHipplenInheritCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetHipplenInheritCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxHZXRIaXBwbGVuSW5oZXJpdENzUmVxLnByb3RvIhgKFkdldEhpcHBsZW5J" + "bmhlcml0Q3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetHipplenInheritCsReq), GetHipplenInheritCsReq.Parser, null, null, null, null, null)
		}));
	}
}
