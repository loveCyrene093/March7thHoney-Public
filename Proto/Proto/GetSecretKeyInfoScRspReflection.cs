using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetSecretKeyInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetSecretKeyInfoScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChtHZXRTZWNyZXRLZXlJbmZvU2NSc3AucHJvdG8aE1NlY3JldEtleUluZm8u";
		buffer[1] = "cHJvdG8iYQoVR2V0U2VjcmV0S2V5SW5mb1NjUnNwEiMKC3NlY3JldF9pbmZv";
		buffer[2] = "GAIgAygLMg4uU2VjcmV0S2V5SW5mbxIPCgdyZXRjb2RlGAwgASgNEhIKCnNl";
		buffer[3] = "Y3JldF9yc3AYDiABKAxCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[4] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { SecretKeyInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetSecretKeyInfoScRsp), GetSecretKeyInfoScRsp.Parser, new string[3] { "SecretInfo", "Retcode", "SecretRsp" }, null, null, null, null)
		}));
	}
}
