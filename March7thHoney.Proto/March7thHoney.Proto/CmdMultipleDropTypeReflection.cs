using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdMultipleDropTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdMultipleDropTypeReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "ChlDbWRNdWx0aXBsZURyb3BUeXBlLnByb3RvKo4CChNDbWRNdWx0aXBsZURy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "b3BUeXBlEhsKF0ZMUFBOSkdFTUZOX1BDUERIRUxQS0VNEAASIAobQ21kTXVs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "dGlwbGVEcm9wSW5mb1NjTm90aWZ5ENYkEh4KGUNtZE11bHRpcGxlRHJvcElu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "Zm9Ob3RpZnkQiiQSIAobQ21kR2V0TXVsdGlwbGVEcm9wSW5mb0NzUmVxENMk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "EikKJENtZEdldFBsYXllclJldHVybk11bHRpRHJvcEluZm9TY1JzcBCGJBIp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "CiRDbWRHZXRQbGF5ZXJSZXR1cm5NdWx0aURyb3BJbmZvQ3NSZXEQ1yQSIAob";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "Q21kR2V0TXVsdGlwbGVEcm9wSW5mb1NjUnNwEIIkQhaqAhNNYXJjaDd0aEhv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdMultipleDropType) }, null, null));
	}
}
