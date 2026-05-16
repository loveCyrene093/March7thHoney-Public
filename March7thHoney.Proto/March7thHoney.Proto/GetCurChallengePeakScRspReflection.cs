using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetCurChallengePeakScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetCurChallengePeakScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "Ch5HZXRDdXJDaGFsbGVuZ2VQZWFrU2NSc3AucHJvdG8isgEKGEdldEN1ckNo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "YWxsZW5nZVBlYWtTY1JzcBIUCgxib3NzX2J1ZmZfaWQYASABKA0SEgoKaGFz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "X3Bhc3NlZBgDIAEoCBIXCg9pc193YWl0X2NvbmZpcm0YBiABKAgSEwoLY3lj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "bGVzX3VzZWQYCyABKA0SDwoHcmV0Y29kZRgMIAEoDRIcChRmaW5pc2hlZF90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "YXJnZXRfbGlzdBgNIAMoDRIPCgdwZWFrX2lkGA4gASgNQhaqAhNNYXJjaDd0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetCurChallengePeakScRsp), GetCurChallengePeakScRsp.Parser, new string[7] { "BossBuffId", "HasPassed", "IsWaitConfirm", "CyclesUsed", "Retcode", "FinishedTargetList", "PeakId" }, null, null, null, null)
		}));
	}
}
