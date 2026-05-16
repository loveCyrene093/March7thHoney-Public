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
		buffer[0] = "CidSZWxpY1NtYXJ0V2VhckRlbGV0ZVBpblJlbGljU2NSc3AucHJvdG8aEU5I";
		buffer[1] = "Rk9HRFBCT0hOLnByb3RvImoKIVJlbGljU21hcnRXZWFyRGVsZXRlUGluUmVs";
		buffer[2] = "aWNTY1JzcBIhCgtESENOTUlBSUJHRhgFIAMoCzIMLk5IRk9HRFBCT0hOEhEK";
		buffer[3] = "CWF2YXRhcl9pZBgLIAEoDRIPCgdyZXRjb2RlGA4gASgNQhaqAhNNYXJjaDd0";
		buffer[4] = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { NHFOGDPBOHNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RelicSmartWearDeletePinRelicScRsp), RelicSmartWearDeletePinRelicScRsp.Parser, new string[3] { "DHCNMIAIBGF", "AvatarId", "Retcode" }, null, null, null, null)
		}));
	}
}
