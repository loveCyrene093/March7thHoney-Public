using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdFateTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdFateTypeReflection()
	{
		_003C_003Ey__InlineArray21<string> buffer = default(_003C_003Ey__InlineArray21<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 0) = "ChFDbWRGYXRlVHlwZS5wcm90byrTBgoLQ21kRmF0ZVR5cGUSGwoXTkFBT01J";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 1) = "R1BNSEVfUENQREhFTFBLRU0QABIWChFDbWRGYXRlU3RhcnRDc1JlcRDcLhIe";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 2) = "ChlDbWRGYXRlU2hvcExvY2tHb29kc1NjUnNwEMEuEiQKH0NtZEZhdGVTeW5j";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 3) = "QWN0aW9uUmVzdWx0U2NOb3RpZnkQ7y4SHAoXQ21kRmF0ZUJhdHRsZVN0YXJ0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 4) = "U2NSc3AQ5C4SFgoRQ21kRmF0ZVN0YXJ0U2NSc3AQ2S4SGgoVQ21kRmF0ZVNl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 5) = "dHRsZVNjTm90aWZ5EMYuEh0KGENtZEZhdGVDaGFuZ2VMaW5ldXBDc1JlcRDD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 6) = "LhIhChxDbWRGYXRlU2hvcFJlZnJlc2hHb29kc1NjUnNwEOsuEiEKHENtZEZh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 7) = "dGVTaG9wUmVmcmVzaEdvb2RzQ3NSZXEQ0C4SHAoXQ21kRmF0ZUJhdHRsZVN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 8) = "YXJ0Q3NSZXEQ4S4SHgoZQ21kRmF0ZVRha2VFeHBSZXdhcmRTY1JzcBDHLhIl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 9) = "CiBDbWRGYXRlU3luY1BlbmRpbmdBY3Rpb25TY05vdGlmeRDNLhIdChhDbWRG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 10) = "YXRlU2hvcEJ1eUdvb2RzQ3NSZXEQ7S4SHQoYQ21kRmF0ZUNoYW5nZUxpbmV1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 11) = "cFNjUnNwEL8uEh4KGUNtZEZhdGVUYWtlRXhwUmV3YXJkQ3NSZXEQ3y4SHgoZ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 12) = "Q21kRmF0ZVNob3BMb2NrR29vZHNDc1JlcRDiLhIWChFDbWRGYXRlUXVlcnlD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 13) = "c1JlcRDLLhIWChFDbWRGYXRlUXVlcnlTY1JzcBDFLhIdChhDbWRGYXRlU2hv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 14) = "cFNlbGxCdWZmQ3NSZXEQwC4SHQoYQ21kRmF0ZVNob3BCdXlHb29kc1NjUnNw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 15) = "ENEuEhoKFUNtZEZhdGVTaG9wTGVhdmVDc1JlcRDwLhIaChVDbWRGYXRlSG91";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 16) = "Z3VTZWxlY3RSZXEQ3S4SGgoVQ21kRmF0ZVNob3BMZWF2ZVNjUnNwEM4uEh0K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 17) = "GENtZEZhdGVTaG9wU2VsbEJ1ZmZTY1JzcBDqLhITCg5DbWRFUEVJQk9NTkVH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 18) = "SRDELhIkCh9DbWRGYXRlSGFuZGxlUGVuZGluZ0FjdGlvblNjUnNwENMuEhMK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 19) = "DkNtZEpGREFCTUpNRExEENguQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 20) = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray21<string>, string>(in buffer, 21))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdFateType) }, null, null));
	}
}
