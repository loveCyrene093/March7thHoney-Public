using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetStoryLineInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetStoryLineInfoScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChtHZXRTdG9yeUxpbmVJbmZvU2NSc3AucHJvdG8iiAEKFUdldFN0b3J5TGlu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "ZUluZm9TY1JzcBIlCh11bmZpbmlzaGVkX3N0b3J5X2xpbmVfaWRfbGlzdBgG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "IAMoDRIPCgdyZXRjb2RlGAcgASgNEhwKFHRyaWFsX2F2YXRhcl9pZF9saXN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "GAggAygNEhkKEWN1cl9zdG9yeV9saW5lX2lkGAwgASgNQhaqAhNNYXJjaDd0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetStoryLineInfoScRsp), GetStoryLineInfoScRsp.Parser, new string[4] { "UnfinishedStoryLineIdList", "Retcode", "TrialAvatarIdList", "CurStoryLineId" }, null, null, null, null)
		}));
	}
}
