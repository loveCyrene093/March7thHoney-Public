using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMissionDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMissionDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlHZXRNaXNzaW9uRGF0YUNzUmVxLnByb3RvIhUKE0dldE1pc3Npb25EYXRh" + "Q3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMissionDataCsReq), GetMissionDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
