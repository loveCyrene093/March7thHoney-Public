using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdHeartdialTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdHeartdialTypeReflection()
	{
		InlineArray12<string> buffer = default(InlineArray12<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 0) = "ChZDbWRIZWFydGRpYWxUeXBlLnByb3RvKrwDChBDbWRIZWFydGRpYWxUeXBl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 1) = "EhsKF05JT0ZESUZBREVLX1BDUERIRUxQS0VNEAASHgoZQ21kU3VibWl0RW1v";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 2) = "dGlvbkl0ZW1Dc1JlcRCqMRIhChxDbWRIZWFydERpYWxUcmFjZVNjcmlwdENz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 3) = "UmVxELYxEh4KGUNtZFN1Ym1pdEVtb3Rpb25JdGVtU2NSc3AQrjESJQogQ21k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 4) = "SGVhcnREaWFsU2NyaXB0Q2hhbmdlU2NOb3RpZnkQ2zESHQoYQ21kR2V0SGVh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 5) = "cnREaWFsSW5mb0NzUmVxEPcxEiEKHENtZEhlYXJ0RGlhbFRyYWNlU2NyaXB0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 6) = "U2NSc3AQwzESIAobQ21kQ2hhbmdlU2NyaXB0RW1vdGlvbkNzUmVxEPoxEi0K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 7) = "KENtZEZpbmlzaEVtb3Rpb25EaWFsb2d1ZVBlcmZvcm1hbmNlU2NSc3AQ/jES";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 8) = "IAobQ21kQ2hhbmdlU2NyaXB0RW1vdGlvblNjUnNwEPsxEi0KKENtZEZpbmlz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 9) = "aEVtb3Rpb25EaWFsb2d1ZVBlcmZvcm1hbmNlQ3NSZXEQpTESHQoYQ21kR2V0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 10) = "SGVhcnREaWFsSW5mb1NjUnNwEKYxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 11) = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray12<string>, string>(in buffer, 12))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdHeartdialType) }, null, null));
	}
}
