using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetArchiveDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetArchiveDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlHZXRBcmNoaXZlRGF0YUNzUmVxLnByb3RvIhUKE0dldEFyY2hpdmVEYXRh" + "Q3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetArchiveDataCsReq), GetArchiveDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
