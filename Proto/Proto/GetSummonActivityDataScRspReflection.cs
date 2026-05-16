using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetSummonActivityDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetSummonActivityDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBHZXRTdW1tb25BY3Rpdml0eURhdGFTY1JzcC5wcm90bxoRTEdJSURFTktQ" + "SUcucHJvdG8iUAoaR2V0U3VtbW9uQWN0aXZpdHlEYXRhU2NSc3ASIQoLS0xE" + "TEZFS0RIT0MYAiADKAsyDC5MR0lJREVOS1BJRxIPCgdyZXRjb2RlGAsgASgN" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { LGIIDENKPIGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetSummonActivityDataScRsp), GetSummonActivityDataScRsp.Parser, new string[2] { "KLDLFEKDHOC", "Retcode" }, null, null, null, null)
		}));
	}
}
