using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMaterialSubmitActivityDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMaterialSubmitActivityDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihHZXRNYXRlcmlhbFN1Ym1pdEFjdGl2aXR5RGF0YUNzUmVxLnByb3RvIiQK" + "IkdldE1hdGVyaWFsU3VibWl0QWN0aXZpdHlEYXRhQ3NSZXFCFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMaterialSubmitActivityDataCsReq), GetMaterialSubmitActivityDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
