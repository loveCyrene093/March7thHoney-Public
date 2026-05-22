using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdRelicBoxTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdRelicBoxTypeReflection()
	{
		InlineArray12<string> buffer = default(InlineArray12<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 0) = "ChVDbWRSZWxpY0JveFR5cGUucHJvdG8qwwMKD0NtZFJlbGljQm94VHlwZRIb";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 1) = "ChdFT0lDQ1BLUEZQQl9QQ1BESEVMUEtFTRAAEh4KGUNtZFNldFJlbGljQm94";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 2) = "VGFyZ2V0U2NSc3AQ/kUSHgoZQ21kU2V0UmVsaWNCb3hDdXN0b21Dc1JlcRD4";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 3) = "RRIeChlDbWRTZXRSZWxpY0JveEN1c3RvbVNjUnNwEIBGEh8KGkNtZFJlbGlj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 4) = "Qm94UmVndWxhclNjTm90aWZ5EINGEh4KGUNtZFNldFJlbGljQm94VGFyZ2V0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 5) = "Q3NSZXEQhUYSHAoXQ21kQ29uZmlybVJlbGljQm94U2NSc3AQiEYSHAoXQ21k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 6) = "Q29uZmlybVJlbGljQm94Q3NSZXEQgUYSGQoUQ21kT3BlblJlbGljQm94U2NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 7) = "c3AQiUYSGQoUQ21kT3BlblJlbGljQm94Q3NSZXEQ/UUSHAoXQ21kR2V0UmVs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 8) = "aWNCb3hEYXRhU2NSc3AQikYSIQocQ21kUmVwb3J0UmVsaWNCb3hBY3Rpb25T";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 9) = "Y1JzcBD/RRIcChdDbWRHZXRSZWxpY0JveERhdGFDc1JlcRD3RRIhChxDbWRS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 10) = "ZXBvcnRSZWxpY0JveEFjdGlvbkNzUmVxEPlFQhaqAhNNYXJjaDd0aEhvbmV5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 11) = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray12<string>, string>(in buffer, 12))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdRelicBoxType) }, null, null));
	}
}
