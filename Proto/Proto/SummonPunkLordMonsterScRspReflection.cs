using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SummonPunkLordMonsterScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SummonPunkLordMonsterScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBTdW1tb25QdW5rTG9yZE1vbnN0ZXJTY1JzcC5wcm90bxoRQ0lLSkhMTU9P" + "SUsucHJvdG8iUAoaU3VtbW9uUHVua0xvcmRNb25zdGVyU2NSc3ASIQoLRkZD" + "RFBITUpKS0cYDCABKAsyDC5DSUtKSExNT09JSxIPCgdyZXRjb2RlGA0gASgN" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { CIKJHLMOOIKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SummonPunkLordMonsterScRsp), SummonPunkLordMonsterScRsp.Parser, new string[2] { "FFCDPHMJJKG", "Retcode" }, null, null, null, null)
		}));
	}
}
