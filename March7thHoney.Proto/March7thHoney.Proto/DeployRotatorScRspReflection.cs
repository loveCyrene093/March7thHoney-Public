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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChhEZXBsb3lSb3RhdG9yU2NSc3AucHJvdG8aEVJvdGF0ZXJEYXRhLnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "GhdSb3RhdGVyRW5lcmd5SW5mby5wcm90byJyChJEZXBsb3lSb3RhdG9yU2NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "c3ASIgoMcm90YXRlcl9kYXRhGAMgASgLMgwuUm90YXRlckRhdGESJwoLZW5l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "cmd5X2luZm8YDSABKAsyEi5Sb3RhdGVyRW5lcmd5SW5mbxIPCgdyZXRjb2Rl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "GA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			RotaterDataReflection.Descriptor,
			RotaterEnergyInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DeployRotatorScRsp), DeployRotatorScRsp.Parser, new string[3] { "RotaterData", "EnergyInfo", "Retcode" }, null, null, null, null)
		}));
	}
}
