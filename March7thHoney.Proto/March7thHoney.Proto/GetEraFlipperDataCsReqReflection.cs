using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetEraFlipperDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetEraFlipperDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxHZXRFcmFGbGlwcGVyRGF0YUNzUmVxLnByb3RvIhgKFkdldEVyYUZsaXBw" + "ZXJEYXRhQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetEraFlipperDataCsReq), GetEraFlipperDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
