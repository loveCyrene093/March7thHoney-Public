using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MatchThreeGetDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MatchThreeGetDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxNYXRjaFRocmVlR2V0RGF0YUNzUmVxLnByb3RvIhgKFk1hdGNoVGhyZWVH" + "ZXREYXRhQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MatchThreeGetDataCsReq), MatchThreeGetDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
