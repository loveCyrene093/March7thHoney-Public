using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OpenHipplenCycleScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OpenHipplenCycleScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtPcGVuSGlwcGxlbkN5Y2xlU2NSc3AucHJvdG8aEU9PTEhORk5LT0hOLnBy" + "b3RvImAKFU9wZW5IaXBwbGVuQ3ljbGVTY1JzcBIPCgdyZXRjb2RlGAEgASgN" + "EiEKC0FDSkhHTEdIRUFIGAMgASgLMgwuT09MSE5GTktPSE4SEwoLSVBPRUlH" + "QURMSk4YCSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { OOLHNFNKOHNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OpenHipplenCycleScRsp), OpenHipplenCycleScRsp.Parser, new string[3] { "Retcode", "ACJHGLGHEAH", "IPOEIGADLJN" }, null, null, null, null)
		}));
	}
}
