using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnhanceRogueBuffScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnhanceRogueBuffScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChtFbmhhbmNlUm9ndWVCdWZmU2NSc3AucHJvdG8aEURBR0JDSklISkJNLnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "b3RvGhFISkdGRElLRElITy5wcm90byKDAQoVRW5oYW5jZVJvZ3VlQnVmZlNj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "UnNwEhMKC0RBSUtOS0FMS0NNGAYgASgIEiEKC0ZHTEpPS0lMS0hHGAwgASgL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "MgwuREFHQkNKSUhKQk0SIQoLQUdGUEZPRFBPRkEYDSABKAsyDC5ISkdGRElL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "RElITxIPCgdyZXRjb2RlGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			DAGBCJIHJBMReflection.Descriptor,
			HJGFDIKDIHOReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnhanceRogueBuffScRsp), EnhanceRogueBuffScRsp.Parser, new string[4] { "DAIKNKALKCM", "FGLJOKILKHG", "AGFPFODPOFA", "Retcode" }, null, null, null, null)
		}));
	}
}
