using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetTrialActivityDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetTrialActivityDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9HZXRUcmlhbEFjdGl2aXR5RGF0YUNzUmVxLnByb3RvIhsKGUdldFRyaWFs" + "QWN0aXZpdHlEYXRhQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetTrialActivityDataCsReq), GetTrialActivityDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
