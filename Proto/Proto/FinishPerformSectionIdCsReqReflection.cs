using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishPerformSectionIdCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishPerformSectionIdCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFGaW5pc2hQZXJmb3JtU2VjdGlvbklkQ3NSZXEucHJvdG8aEU1lc3NhZ2VJ" + "dGVtLnByb3RvIlIKG0ZpbmlzaFBlcmZvcm1TZWN0aW9uSWRDc1JlcRIfCglp" + "dGVtX2xpc3QYCSADKAsyDC5NZXNzYWdlSXRlbRISCgpzZWN0aW9uX2lkGAwg" + "ASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { MessageItemReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishPerformSectionIdCsReq), FinishPerformSectionIdCsReq.Parser, new string[2] { "ItemList", "SectionId" }, null, null, null, null)
		}));
	}
}
