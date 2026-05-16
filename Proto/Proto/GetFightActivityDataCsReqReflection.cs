using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFightActivityDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFightActivityDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9HZXRGaWdodEFjdGl2aXR5RGF0YUNzUmVxLnByb3RvIhsKGUdldEZpZ2h0" + "QWN0aXZpdHlEYXRhQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFightActivityDataCsReq), GetFightActivityDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
