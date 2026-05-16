using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainPartyGamePlaySettleNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainPartyGamePlaySettleNotifyReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CiRUcmFpblBhcnR5R2FtZVBsYXlTZXR0bGVOb3RpZnkucHJvdG8aHVRyYWlu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "UGFydHlQYXNzZW5nZXJJbmZvLnByb3RvIpABCh5UcmFpblBhcnR5R2FtZVBs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "YXlTZXR0bGVOb3RpZnkSEwoLSUVOR0VQQ0hITUMYBSADKA0SFwoPdW5sb2Nr";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "X2FyZWFfbnVtGAkgASgNEhEKCXJlY29yZF9pZBgKIAEoDRItCgtGSUpISUVP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "QU5OTRgMIAEoCzIYLlRyYWluUGFydHlQYXNzZW5nZXJJbmZvQhaqAhNNYXJj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { TrainPartyPassengerInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainPartyGamePlaySettleNotify), TrainPartyGamePlaySettleNotify.Parser, new string[4] { "IENGEPCHHMC", "UnlockAreaNum", "RecordId", "FIJHIEOANNM" }, null, null, null, null)
		}));
	}
}
