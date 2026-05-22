using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightLockInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightLockInfoReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChdHcmlkRmlnaHRMb2NrSW5mby5wcm90bxoZR3JpZEZpZ2h0TG9ja1JlYXNv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "bi5wcm90bxoXR3JpZEZpZ2h0TG9ja1R5cGUucHJvdG8iZQoRR3JpZEZpZ2h0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "TG9ja0luZm8SKQoLbG9ja19yZWFzb24YByABKA4yFC5HcmlkRmlnaHRMb2Nr";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "UmVhc29uEiUKCWxvY2tfdHlwZRgKIAEoDjISLkdyaWRGaWdodExvY2tUeXBl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			GridFightLockReasonReflection.Descriptor,
			GridFightLockTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightLockInfo), GridFightLockInfo.Parser, new string[2] { "LockReason", "LockType" }, null, null, null, null)
		}));
	}
}
