using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetChallengePeakDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetChallengePeakDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9HZXRDaGFsbGVuZ2VQZWFrRGF0YUNzUmVxLnByb3RvIhsKGUdldENoYWxs" + "ZW5nZVBlYWtEYXRhQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetChallengePeakDataCsReq), GetChallengePeakDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
