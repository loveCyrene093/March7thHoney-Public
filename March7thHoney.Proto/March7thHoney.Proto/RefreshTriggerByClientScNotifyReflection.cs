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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiRSZWZyZXNoVHJpZ2dlckJ5Q2xpZW50U2NOb3RpZnkucHJvdG8icQoeUmVm";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "cmVzaFRyaWdnZXJCeUNsaWVudFNjTm90aWZ5EhQKDHRyaWdnZXJfbmFtZRgB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "IAEoCRIeChZ0cmlnZ2VyX3RhcmdldF9pZF9saXN0GAMgAygNEhkKEXRyaWdn";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "ZXJfZW50aXR5X2lkGAUgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RefreshTriggerByClientScNotify), RefreshTriggerByClientScNotify.Parser, new string[3] { "TriggerName", "TriggerTargetIdList", "TriggerEntityId" }, null, null, null, null)
		}));
	}
}
