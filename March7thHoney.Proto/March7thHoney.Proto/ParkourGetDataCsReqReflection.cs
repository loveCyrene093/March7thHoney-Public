using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ParkourGetDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ParkourGetDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlQYXJrb3VyR2V0RGF0YUNzUmVxLnByb3RvIhUKE1BhcmtvdXJHZXREYXRh" + "Q3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ParkourGetDataCsReq), ParkourGetDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
