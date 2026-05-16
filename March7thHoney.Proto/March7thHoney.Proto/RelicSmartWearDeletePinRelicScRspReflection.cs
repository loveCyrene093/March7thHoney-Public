using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RelicSmartWearDeletePinRelicScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RelicSmartWearDeletePinRelicScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CidSZWxpY1NtYXJ0V2VhckRlbGV0ZVBpblJlbGljU2NSc3AucHJvdG8aEU5I";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "Rk9HRFBCT0hOLnByb3RvImoKIVJlbGljU21hcnRXZWFyRGVsZXRlUGluUmVs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "aWNTY1JzcBIhCgtESENOTUlBSUJHRhgFIAMoCzIMLk5IRk9HRFBCT0hOEhEK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "CWF2YXRhcl9pZBgLIAEoDRIPCgdyZXRjb2RlGA4gASgNQhaqAhNNYXJjaDd0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { NHFOGDPBOHNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RelicSmartWearDeletePinRelicScRsp), RelicSmartWearDeletePinRelicScRsp.Parser, new string[3] { "DHCNMIAIBGF", "AvatarId", "Retcode" }, null, null, null, null)
		}));
	}
}
