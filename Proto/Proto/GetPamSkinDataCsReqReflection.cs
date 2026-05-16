using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetPamSkinDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetPamSkinDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlHZXRQYW1Ta2luRGF0YUNzUmVxLnByb3RvIhUKE0dldFBhbVNraW5EYXRh" + "Q3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetPamSkinDataCsReq), GetPamSkinDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
