using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RefreshTriggerByClientScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RefreshTriggerByClientScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiRSZWZyZXNoVHJpZ2dlckJ5Q2xpZW50U2NOb3RpZnkucHJvdG8icQoeUmVm";
		buffer[1] = "cmVzaFRyaWdnZXJCeUNsaWVudFNjTm90aWZ5EhQKDHRyaWdnZXJfbmFtZRgB";
		buffer[2] = "IAEoCRIeChZ0cmlnZ2VyX3RhcmdldF9pZF9saXN0GAMgAygNEhkKEXRyaWdn";
		buffer[3] = "ZXJfZW50aXR5X2lkGAUgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		buffer[4] = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RefreshTriggerByClientScNotify), RefreshTriggerByClientScNotify.Parser, new string[3] { "TriggerName", "TriggerTargetIdList", "TriggerEntityId" }, null, null, null, null)
		}));
	}
}
