using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetSwordTrainingDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetSwordTrainingDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9HZXRTd29yZFRyYWluaW5nRGF0YUNzUmVxLnByb3RvIhsKGUdldFN3b3Jk" + "VHJhaW5pbmdEYXRhQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetSwordTrainingDataCsReq), GetSwordTrainingDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
