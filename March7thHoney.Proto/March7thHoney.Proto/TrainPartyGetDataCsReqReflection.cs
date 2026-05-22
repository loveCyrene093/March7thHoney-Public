using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainPartyGetDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainPartyGetDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxUcmFpblBhcnR5R2V0RGF0YUNzUmVxLnByb3RvIhgKFlRyYWluUGFydHlH" + "ZXREYXRhQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainPartyGetDataCsReq), TrainPartyGetDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
