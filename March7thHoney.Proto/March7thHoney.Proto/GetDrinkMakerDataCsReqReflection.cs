using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetDrinkMakerDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetDrinkMakerDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxHZXREcmlua01ha2VyRGF0YUNzUmVxLnByb3RvIhgKFkdldERyaW5rTWFr" + "ZXJEYXRhQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetDrinkMakerDataCsReq), GetDrinkMakerDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
