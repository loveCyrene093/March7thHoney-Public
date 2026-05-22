using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdMessageTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdMessageTypeReflection()
	{
		InlineArray11<string> buffer = default(InlineArray11<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 0) = "ChRDbWRNZXNzYWdlVHlwZS5wcm90byqhAwoOQ21kTWVzc2FnZVR5cGUSGwoX";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 1) = "UEhMTU1PSlBLSEFfUENQREhFTFBLRU0QABIZChRDbWRGaW5pc2hJdGVtSWRT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 2) = "Y1JzcBCeFRIeChlDbWRHZXRNaXNzaW9uTWVzc2FnZVNjUnNwEI0VEiMKHkNt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 3) = "ZEZpbmlzaFBlcmZvcm1TZWN0aW9uSWRTY1JzcBCmFRIcChdDbWRGaW5pc2hT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 4) = "ZWN0aW9uSWRTY1JzcBDuFRIcChdDbWRGaW5pc2hTZWN0aW9uSWRDc1JlcRCV";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 5) = "FRIZChRDbWRGaW5pc2hJdGVtSWRDc1JlcRCaFRIjCh5DbWRGaW5pc2hQZXJm";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 6) = "b3JtU2VjdGlvbklkQ3NSZXEQyxUSGQoUQ21kR2V0TnBjU3RhdHVzQ3NSZXEQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 7) = "6hUSHgoZQ21kR2V0TWlzc2lvbk1lc3NhZ2VDc1JlcRCzFRIfChpDbWRHZXRO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 8) = "cGNNZXNzYWdlR3JvdXBDc1JlcRDnFRIfChpDbWRHZXROcGNNZXNzYWdlR3Jv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 9) = "dXBTY1JzcBCWFRIZChRDbWRHZXROcGNTdGF0dXNTY1JzcBDrFUIWqgITTWFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 10) = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray11<string>, string>(in buffer, 11))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdMessageType) }, null, null));
	}
}
