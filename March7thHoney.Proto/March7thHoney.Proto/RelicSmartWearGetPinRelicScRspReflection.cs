using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RelicSmartWearGetPinRelicScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RelicSmartWearGetPinRelicScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiRSZWxpY1NtYXJ0V2VhckdldFBpblJlbGljU2NSc3AucHJvdG8aEUJERUtF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "SUtBS01MLnByb3RvImcKHlJlbGljU21hcnRXZWFyR2V0UGluUmVsaWNTY1Jz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "cBIhCgtIQlBHT0lMQk1JTxgGIAMoCzIMLkJERUtFSUtBS01MEhEKCWF2YXRh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "cl9pZBgJIAEoDRIPCgdyZXRjb2RlGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { BDEKEIKAKMLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RelicSmartWearGetPinRelicScRsp), RelicSmartWearGetPinRelicScRsp.Parser, new string[3] { "HBPGOILBMIO", "AvatarId", "Retcode" }, null, null, null, null)
		}));
	}
}
