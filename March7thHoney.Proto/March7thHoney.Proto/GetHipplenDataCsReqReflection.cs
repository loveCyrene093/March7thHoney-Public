using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetHipplenDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetHipplenDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlHZXRIaXBwbGVuRGF0YUNzUmVxLnByb3RvIhUKE0dldEhpcHBsZW5EYXRh" + "Q3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetHipplenDataCsReq), GetHipplenDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
