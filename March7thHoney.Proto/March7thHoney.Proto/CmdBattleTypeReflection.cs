using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdBattleTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdBattleTypeReflection()
	{
		InlineArray12<string> buffer = default(InlineArray12<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 0) = "ChNDbWRCYXR0bGVUeXBlLnByb3RvKuMDCg1DbWRCYXR0bGVUeXBlEhsKF0pI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 1) = "SEVCSE9LT0VLX1BDUERIRUxQS0VNEAASGwoXQ21kUFZFQmF0dGxlUmVzdWx0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 2) = "U2NSc3AQbhIgChxDbWRTeW5jQ2xpZW50UmVzVmVyc2lvbkNzUmVxEG0SEwoO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 3) = "Q21kUEROUElDUEVDQUMQwwESGgoVQ21kUXVpdEJhdHRsZVNjTm90aWZ5EKMB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 4) = "EhsKF0pISEVCSE9LT0VLX0tBUE9CR0RMSEdDEH4SKQolQ21kU2VydmVyU2lt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 5) = "dWxhdGVCYXR0bGVGaW5pc2hTY05vdGlmeRBlEiAKG0NtZFJlYmF0dGxlQnlD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 6) = "bGllbnRDc05vdGlmeRCJARIcChdDbWRCYXR0bGVMb2dSZXBvcnRTY1JzcBCL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 7) = "ARIXChJDbWRRdWl0QmF0dGxlQ3NSZXEQwgESHAoYQ21kR2V0Q3VyQmF0dGxl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 8) = "SW5mb1NjUnNwEHYSHAoYQ21kR2V0Q3VyQmF0dGxlSW5mb0NzUmVxEHISJwoi";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 9) = "Q21kUmVCYXR0bGVBZnRlckJhdHRsZUxvc2VDc05vdGlmeRCuARIcChdDbWRQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 10) = "VkVCYXR0bGVSZXN1bHRDc1JlcRC/ARIhChxDbWRTeW5jQ2xpZW50UmVzVmVy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 11) = "c2lvblNjUnNwEMYBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray12<string>, string>(in buffer, 12))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdBattleType) }, null, null));
	}
}
