using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetJukeboxDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetJukeboxDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlHZXRKdWtlYm94RGF0YUNzUmVxLnByb3RvIhUKE0dldEp1a2Vib3hEYXRh" + "Q3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetJukeboxDataCsReq), GetJukeboxDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
