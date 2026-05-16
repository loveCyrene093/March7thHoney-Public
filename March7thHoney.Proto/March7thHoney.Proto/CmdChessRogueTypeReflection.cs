using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdChessRogueTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdChessRogueTypeReflection()
	{
		_003C_003Ey__InlineArray67<string> buffer = default(_003C_003Ey__InlineArray67<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 0) = "ChdDbWRDaGVzc1JvZ3VlVHlwZS5wcm90byqHFwoRQ21kQ2hlc3NSb2d1ZVR5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 1) = "cGUSGwoXSE9CQUVQS0ZGUERfUENQREhFTFBLRU0QABIqCiVDbWRDaGVzc1Jv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 2) = "Z3VlVXBkYXRlUmV2aXZlSW5mb1NjTm90aWZ5EJwrEhwKF0NtZENoZXNzUm9n";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 3) = "dWVRdWVyeVNjUnNwENUrEhMKDkNtZE1OUEFBS0dIQkVKEI0rEiUKIENtZENo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 4) = "ZXNzUm9ndWVFbnRlck5leHRMYXllclNjUnNwEMkqEh4KGUNtZFJldml2ZVJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 5) = "Z3VlQXZhdGFyQ3NSZXEQrCoSJQogQ21kU2VsZWN0Q2hlc3NSb2d1ZVN1YlN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 6) = "b3J5Q3NSZXEQoioSIQocQ21kQ2hlc3NSb2d1ZUxheWVyU2V0dGxlbWVudBDj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 7) = "KhIcChdDbWRDaGVzc1JvZ3VlTGVhdmVTY1JzcBC7KhIpCiRDbWRDaGVzc1Jv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 8) = "Z3VlVXBkYXRlTW9uZXlJbmZvU2NOb3RpZnkQ2isSEwoOQ21kQk5JQkhBT0pL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 9) = "QkkQgysSKwomQ21kQ2hlc3NSb2d1ZUNoYW5nZUFlb25EaW1lbnNpb25Ob3Rp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 10) = "ZnkQuioSHwoaQ21kQ2hlc3NSb2d1ZVJvbGxEaWNlU2NSc3AQ4SoSKwomQ21k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 11) = "R2V0Q2hlc3NSb2d1ZVN0b3J5QWVvblRhbGtJbmZvU2NSc3AQnSoSJQogQ21k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 12) = "RmluaXNoQ2hlc3NSb2d1ZVN1YlN0b3J5U2NSc3AQiysSIwoeQ21kQ2hlc3NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 13) = "b2d1ZU5vdXNFZGl0RGljZVNjUnNwEKkqEhsKFkNtZENoZXNzUm9ndWVRdWl0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 14) = "Q3NSZXEQ8CoSIAobQ21kQ2hlc3NSb2d1ZUVudGVyQ2VsbENzUmVxEKcqEiEK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 15) = "HENtZENoZXNzUm9ndWVTZWxlY3RDZWxsU2NSc3AQvCoSIAobQ21kQ2hlc3NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 16) = "b2d1ZUVudGVyQ2VsbFNjUnNwELYrEh0KGENtZEVuaGFuY2VSb2d1ZUJ1ZmZD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 17) = "c1JlcRC/KhIrCiZDbWRDaGVzc1JvZ3VlVXBkYXRlVW5sb2NrTGV2ZWxTY05v";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 18) = "dGlmeRD/KhIiCh1DbWRDaGVzc1JvZ3VlQ29uZmlybVJvbGxTY1JzcBDSKhIl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 19) = "CiBDbWRTZWxlY3RDaGVzc1JvZ3VlU3ViU3RvcnlTY1JzcBDpKhIcChdDbWRQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 20) = "aWNrUm9ndWVBdmF0YXJTY1JzcBDEKxIcChdDbWRDaGVzc1JvZ3VlUXVlcnlD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 21) = "c1JlcRCkKxIcChdDbWRDaGVzc1JvZ3VlRW50ZXJDc1JlcRCKKxInCiJDbWRH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 22) = "ZXRDaGVzc1JvZ3VlTm91c1N0b3J5SW5mb0NzUmVxEKUrEiYKIUNtZENoZXNz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 23) = "Um9ndWVOb3VzRGljZVVwZGF0ZU5vdGlmeRDBKhItCihDbWRDaGVzc1JvZ3Vl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 24) = "VXBkYXRlTGV2ZWxCYXNlSW5mb1NjTm90aWZ5EMwqEiMKHkNtZEdldENoZXNz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 25) = "Um9ndWVTdG9yeUluZm9TY1JzcBDAKhIsCidDbWRDaGVzc1JvZ3VlTm91c0Vu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 26) = "YWJsZVJvZ3VlVGFsZW50Q3NSZXEQnysSHAoXQ21kQ2hlc3NSb2d1ZVN0YXJ0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 27) = "Q3NSZXEQjCsSLQooQ21kQ2hlc3NSb2d1ZU5vdXNEaWNlU3VyZmFjZVVubG9j";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 28) = "a05vdGlmeRCOKxIhChxDbWRDaGVzc1JvZ3VlUmVSb2xsRGljZVNjUnNwEJ8q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 29) = "Eh0KGENtZENoZXNzUm9ndWVHaXZlVXBDc1JlcRC1KhIgChtDbWRDaGVzc1Jv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 30) = "Z3VlQ2hlYXRSb2xsQ3NSZXEQ2CoSGwoWQ21kQ2hlc3NSb2d1ZVF1aXRTY1Jz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 31) = "cBD6KhITCg5DbWRMQ0RPQ0tKR0ZDRRCVKxIdChhDbWRDaGVzc1JvZ3VlR2l2";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 32) = "ZVVwU2NSc3AQsisSKwomQ21kU3luY0NoZXNzUm9ndWVOb3VzTWFpblN0b3J5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 33) = "U2NOb3RpZnkQtSsSHwoaQ21kQ2hlc3NSb2d1ZVJvbGxEaWNlQ3NSZXEQ0ysS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 34) = "HgoZQ21kUmV2aXZlUm9ndWVBdmF0YXJTY1JzcBDYKxIxCixDbWRDaGVzc1Jv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 35) = "Z3VlVXBkYXRlQWxsb3dlZFNlbGVjdENlbGxTY05vdGlmeRCZKhI6CjVDbWRD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 36) = "aGVzc1JvZ3VlVXBkYXRlRGljZVBhc3NpdmVBY2N1bXVsYXRlVmFsdWVTY05v";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 37) = "dGlmeRCmKhIiCh1DbWRDaGVzc1JvZ3VlQ29uZmlybVJvbGxDc1JlcRCHKxId";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 38) = "ChhDbWRFbmhhbmNlUm9ndWVCdWZmU2NSc3AQhCsSJAofQ21kRW50ZXJDaGVz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 39) = "c1JvZ3VlQWVvblJvb21TY1JzcBDDKxIxCixDbWRDaGVzc1JvZ3VlVXBkYXRl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 40) = "QWVvbk1vZGlmaWVyVmFsdWVTY05vdGlmeRDSKxItCihDbWRDaGVzc1JvZ3Vl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 41) = "Tm91c0dldFJvZ3VlVGFsZW50SW5mb1NjUnNwEK4qEhwKF0NtZFBpY2tSb2d1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 42) = "ZUF2YXRhckNzUmVxEJoqEiwKJ0NtZENoZXNzUm9ndWVOb3VzRW5hYmxlUm9n";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 43) = "dWVUYWxlbnRTY1JzcBDqKhIiCh1DbWRDaGVzc1JvZ3VlQ2VsbFVwZGF0ZU5v";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 44) = "dGlmeRCFKxIrCiZDbWRDaGVzc1JvZ3VlVXBkYXRlQWN0aW9uUG9pbnRTY05v";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 45) = "dGlmeRC/KxIgChtDbWRDaGVzc1JvZ3VlQ2hlYXRSb2xsU2NSc3AQkisSLQoo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 46) = "Q21kU3luY0NoZXNzUm9ndWVNYWluU3RvcnlGaW5pc2hTY05vdGlmeRCjKhIh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 47) = "ChxDbWRDaGVzc1JvZ3VlUmVSb2xsRGljZUNzUmVxEMcrEiUKIENtZEZpbmlz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 48) = "aENoZXNzUm9ndWVTdWJTdG9yeUNzUmVxEP4qEigKI0NtZENoZXNzUm9ndWVT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 49) = "a2lwVGVhY2hpbmdMZXZlbFNjUnNwEMwrEiMKHkNtZEdldENoZXNzUm9ndWVT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 50) = "dG9yeUluZm9Dc1JlcRCTKxIkCh9DbWRFbnRlckNoZXNzUm9ndWVBZW9uUm9v";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 51) = "bUNzUmVxEKkrEiQKH0NtZEdldFJvZ3VlQnVmZkVuaGFuY2VJbmZvU2NSc3AQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 52) = "qisSKAojQ21kQ2hlc3NSb2d1ZVVwZGF0ZURpY2VJbmZvU2NOb3RpZnkQ5SoS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 53) = "IwoeQ21kQ2hlc3NSb2d1ZVF1ZXN0RmluaXNoTm90aWZ5EN4rEiUKIENtZENo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 54) = "ZXNzUm9ndWVFbnRlck5leHRMYXllckNzUmVxEP0qEioKJUNtZFN5bmNDaGVz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 55) = "c1JvZ3VlTm91c1N1YlN0b3J5U2NOb3RpZnkQlCsSKAojQ21kQ2hlc3NSb2d1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 56) = "ZVNraXBUZWFjaGluZ0xldmVsQ3NSZXEQqCoSJAofQ21kR2V0Um9ndWVCdWZm";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 57) = "RW5oYW5jZUluZm9Dc1JlcRDCKhItCihDbWRDaGVzc1JvZ3VlTm91c0dldFJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 58) = "Z3VlVGFsZW50SW5mb0NzUmVxENcqEhwKF0NtZENoZXNzUm9ndWVMZWF2ZUNz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 59) = "UmVxEM4qEhwKF0NtZENoZXNzUm9ndWVTdGFydFNjUnNwEIIrEicKIkNtZFN5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 60) = "bmNDaGVzc1JvZ3VlTm91c1ZhbHVlU2NOb3RpZnkQyyoSKwomQ21kR2V0Q2hl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 61) = "c3NSb2d1ZVN0b3J5QWVvblRhbGtJbmZvQ3NSZXEQ7yoSJwoiQ21kR2V0Q2hl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 62) = "c3NSb2d1ZU5vdXNTdG9yeUluZm9TY1JzcBCkKhIcChdIT0JBRVBLRkZQRF9Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 63) = "R1BETkxMQk1KQhC6KxIhChxDbWRDaGVzc1JvZ3VlU2VsZWN0Q2VsbENzUmVx";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 64) = "EJ0rEhwKF0hPQkFFUEtGRlBEX0pKUFBKQklLTkJNEM8qEhwKF0NtZENoZXNz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 65) = "Um9ndWVFbnRlclNjUnNwENMqEiIKHUNtZFJlc2V0Um9ndWVEaWNlU3VyZmFj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray67<string>, string>(ref buffer, 66) = "ZUNzUmVxEL0rQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray67<string>, string>(in buffer, 67))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdChessRogueType) }, null, null));
	}
}
