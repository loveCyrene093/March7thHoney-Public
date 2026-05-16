using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraGetDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraGetDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlDaGltZXJhR2V0RGF0YUNzUmVxLnByb3RvIhUKE0NoaW1lcmFHZXREYXRh" + "Q3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraGetDataCsReq), ChimeraGetDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
