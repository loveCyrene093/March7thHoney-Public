using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerReturnInfoQueryScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerReturnInfoQueryScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiBQbGF5ZXJSZXR1cm5JbmZvUXVlcnlTY1JzcC5wcm90bxoRS0tOREVEUERG";
		buffer[1] = "RkwucHJvdG8iZQoaUGxheWVyUmV0dXJuSW5mb1F1ZXJ5U2NSc3ASIQoLQ0FB";
		buffer[2] = "RkJHR0lCS0gYAiABKAsyDC5LS05ERURQREZGTBIPCgdyZXRjb2RlGAcgASgN";
		buffer[3] = "EhMKC0JKTU5QTkZOSE9BGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		buffer[4] = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { KKNDEDPDFFLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerReturnInfoQueryScRsp), PlayerReturnInfoQueryScRsp.Parser, new string[3] { "CAAFBGGIBKH", "Retcode", "BJMNPNFNHOA" }, null, null, null, null)
		}));
	}
}
