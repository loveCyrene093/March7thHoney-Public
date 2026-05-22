using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraDuelShopLockScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraDuelShopLockScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Ch5DaGltZXJhRHVlbFNob3BMb2NrU2NSc3AucHJvdG8iewoYQ2hpbWVyYUR1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "ZWxTaG9wTG9ja1NjUnNwEg8KB3JldGNvZGUYAiABKA0SEQoJaXNfbG9ja2Vk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "GA4gASgIEhUKC0RFQUtPT0VCTEpMGAMgASgNSAASFQoLSENOS0FKTktHRkgY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "DyABKA1IAEINCgtCUElIRkFKQ0xPQ0IWqgITTWFyY2g3dGhIb25leS5Qcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraDuelShopLockScRsp), ChimeraDuelShopLockScRsp.Parser, new string[4] { "Retcode", "IsLocked", "DEAKOOEBLJL", "HCNKAJNKGFH" }, new string[1] { "BPIHFAJCLOC" }, null, null, null)
		}));
	}
}
