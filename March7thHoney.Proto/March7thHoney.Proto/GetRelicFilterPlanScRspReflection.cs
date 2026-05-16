using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRelicFilterPlanScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRelicFilterPlanScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1HZXRSZWxpY0ZpbHRlclBsYW5TY1JzcC5wcm90bxoRRUVDSk1JT0FGRkcu" + "cHJvdG8iTQoXR2V0UmVsaWNGaWx0ZXJQbGFuU2NSc3ASIQoLR0dCQUlMQ0tI" + "TUgYBCADKAsyDC5FRUNKTUlPQUZGRxIPCgdyZXRjb2RlGA4gASgNQhaqAhNN" + "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { EECJMIOAFFGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRelicFilterPlanScRsp), GetRelicFilterPlanScRsp.Parser, new string[2] { "GGBAILCKHMH", "Retcode" }, null, null, null, null)
		}));
	}
}
