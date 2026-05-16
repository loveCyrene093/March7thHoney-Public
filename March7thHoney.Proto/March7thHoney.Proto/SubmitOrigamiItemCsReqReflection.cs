using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SubmitOrigamiItemCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SubmitOrigamiItemCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxTdWJtaXRPcmlnYW1pSXRlbUNzUmVxLnByb3RvIi0KFlN1Ym1pdE9yaWdh" + "bWlJdGVtQ3NSZXESEwoLSU1DSUtOSEhFSEMYCyABKA1CFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SubmitOrigamiItemCsReq), SubmitOrigamiItemCsReq.Parser, new string[1] { "IMCIKNHHEHC" }, null, null, null, null)
		}));
	}
}
