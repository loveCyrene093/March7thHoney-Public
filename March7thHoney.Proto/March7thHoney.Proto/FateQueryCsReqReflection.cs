using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FateQueryCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FateQueryCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRGYXRlUXVlcnlDc1JlcS5wcm90byIQCg5GYXRlUXVlcnlDc1JlcUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FateQueryCsReq), FateQueryCsReq.Parser, null, null, null, null, null)
		}));
	}
}
