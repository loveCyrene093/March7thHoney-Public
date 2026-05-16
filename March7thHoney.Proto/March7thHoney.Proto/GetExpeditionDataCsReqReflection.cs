using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetExpeditionDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetExpeditionDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxHZXRFeHBlZGl0aW9uRGF0YUNzUmVxLnByb3RvIhgKFkdldEV4cGVkaXRp" + "b25EYXRhQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetExpeditionDataCsReq), GetExpeditionDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
