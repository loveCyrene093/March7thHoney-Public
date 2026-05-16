using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerGetTokenScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerGetTokenScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChlQbGF5ZXJHZXRUb2tlblNjUnNwLnByb3RvGg9CbGFja0luZm8ucHJvdG8i";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "kAEKE1BsYXllckdldFRva2VuU2NSc3ASEQoJc3RvcF9kZXNjGAEgASgJEg8K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "B2F1dGhrZXkYAiABKAkSDwoHcmV0Y29kZRgHIAEoDRIXCg9zZWNyZXRfa2V5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "X3NlZWQYCCABKAQSCwoDdWlkGAsgASgNEh4KCmJsYWNrX2luZm8YDiABKAsy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "Ci5CbGFja0luZm9CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { BlackInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerGetTokenScRsp), PlayerGetTokenScRsp.Parser, new string[6] { "StopDesc", "Authkey", "Retcode", "SecretKeySeed", "Uid", "BlackInfo" }, null, null, null, null)
		}));
	}
}
