using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RefreshTriggerByClientScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RefreshTriggerByClientScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiFSZWZyZXNoVHJpZ2dlckJ5Q2xpZW50U2NSc3AucHJvdG8ieAobUmVmcmVz";
		buffer[1] = "aFRyaWdnZXJCeUNsaWVudFNjUnNwEg8KB3JldGNvZGUYCCABKA0SFAoMdHJp";
		buffer[2] = "Z2dlcl9uYW1lGAkgASgJEhkKEXRyaWdnZXJfZW50aXR5X2lkGAogASgNEhcK";
		buffer[3] = "D3JlZnJlc2hfdHJpZ2dlchgNIAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		buffer[4] = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RefreshTriggerByClientScRsp), RefreshTriggerByClientScRsp.Parser, new string[4] { "Retcode", "TriggerName", "TriggerEntityId", "RefreshTrigger" }, null, null, null, null)
		}));
	}
}
