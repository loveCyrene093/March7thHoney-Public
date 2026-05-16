using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DeployRotatorScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DeployRotatorScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChhEZXBsb3lSb3RhdG9yU2NSc3AucHJvdG8aEVJvdGF0ZXJEYXRhLnByb3Rv";
		buffer[1] = "GhdSb3RhdGVyRW5lcmd5SW5mby5wcm90byJyChJEZXBsb3lSb3RhdG9yU2NS";
		buffer[2] = "c3ASIgoMcm90YXRlcl9kYXRhGAMgASgLMgwuUm90YXRlckRhdGESJwoLZW5l";
		buffer[3] = "cmd5X2luZm8YDSABKAsyEi5Sb3RhdGVyRW5lcmd5SW5mbxIPCgdyZXRjb2Rl";
		buffer[4] = "GA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			RotaterDataReflection.Descriptor,
			RotaterEnergyInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DeployRotatorScRsp), DeployRotatorScRsp.Parser, new string[3] { "RotaterData", "EnergyInfo", "Retcode" }, null, null, null, null)
		}));
	}
}
