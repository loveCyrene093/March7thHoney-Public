using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMarkChestScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMarkChestScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdHZXRNYXJrQ2hlc3RTY1JzcC5wcm90bxoXTWFya0NoZXN0RnVuY0luZm8u" + "cHJvdG8iVgoRR2V0TWFya0NoZXN0U2NSc3ASMAoUbWFya19jaGVzdF9mdW5j" + "X2luZm8YASADKAsyEi5NYXJrQ2hlc3RGdW5jSW5mbxIPCgdyZXRjb2RlGAsg" + "ASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { MarkChestFuncInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMarkChestScRsp), GetMarkChestScRsp.Parser, new string[2] { "MarkChestFuncInfo", "Retcode" }, null, null, null, null)
		}));
	}
}
