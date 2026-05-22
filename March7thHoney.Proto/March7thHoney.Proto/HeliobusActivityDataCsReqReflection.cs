using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeliobusActivityDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeliobusActivityDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9IZWxpb2J1c0FjdGl2aXR5RGF0YUNzUmVxLnByb3RvIhsKGUhlbGlvYnVz" + "QWN0aXZpdHlEYXRhQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusActivityDataCsReq), HeliobusActivityDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
