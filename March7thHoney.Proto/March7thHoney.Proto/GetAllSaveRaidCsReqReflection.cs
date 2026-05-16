using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAllSaveRaidCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAllSaveRaidCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlHZXRBbGxTYXZlUmFpZENzUmVxLnByb3RvIhUKE0dldEFsbFNhdmVSYWlk" + "Q3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAllSaveRaidCsReq), GetAllSaveRaidCsReq.Parser, null, null, null, null, null)
		}));
	}
}
