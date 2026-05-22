using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFirstTalkByPerformanceNpcCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFirstTalkByPerformanceNpcCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidHZXRGaXJzdFRhbGtCeVBlcmZvcm1hbmNlTnBjQ3NSZXEucHJvdG8iQAoh" + "R2V0Rmlyc3RUYWxrQnlQZXJmb3JtYW5jZU5wY0NzUmVxEhsKE3BlcmZvcm1h" + "bmNlX2lkX2xpc3QYCiADKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFirstTalkByPerformanceNpcCsReq), GetFirstTalkByPerformanceNpcCsReq.Parser, new string[1] { "PerformanceIdList" }, null, null, null, null)
		}));
	}
}
