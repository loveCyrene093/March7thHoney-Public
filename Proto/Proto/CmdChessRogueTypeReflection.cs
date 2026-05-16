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
		buffer[0] = "ChdDbWRDaGVzc1JvZ3VlVHlwZS5wcm90byqHFwoRQ21kQ2hlc3NSb2d1ZVR5";
		buffer[1] = "cGUSGwoXSE9CQUVQS0ZGUERfUENQREhFTFBLRU0QABIqCiVDbWRDaGVzc1Jv";
		buffer[2] = "Z3VlVXBkYXRlUmV2aXZlSW5mb1NjTm90aWZ5EJwrEhwKF0NtZENoZXNzUm9n";
		buffer[3] = "dWVRdWVyeVNjUnNwENUrEhMKDkNtZE1OUEFBS0dIQkVKEI0rEiUKIENtZENo";
		buffer[4] = "ZXNzUm9ndWVFbnRlck5leHRMYXllclNjUnNwEMkqEh4KGUNtZFJldml2ZVJv";
		buffer[5] = "Z3VlQXZhdGFyQ3NSZXEQrCoSJQogQ21kU2VsZWN0Q2hlc3NSb2d1ZVN1YlN0";
		buffer[6] = "b3J5Q3NSZXEQoioSIQocQ21kQ2hlc3NSb2d1ZUxheWVyU2V0dGxlbWVudBDj";
		buffer[7] = "KhIcChdDbWRDaGVzc1JvZ3VlTGVhdmVTY1JzcBC7KhIpCiRDbWRDaGVzc1Jv";
		buffer[8] = "Z3VlVXBkYXRlTW9uZXlJbmZvU2NOb3RpZnkQ2isSEwoOQ21kQk5JQkhBT0pL";
		buffer[9] = "QkkQgysSKwomQ21kQ2hlc3NSb2d1ZUNoYW5nZUFlb25EaW1lbnNpb25Ob3Rp";
		buffer[10] = "ZnkQuioSHwoaQ21kQ2hlc3NSb2d1ZVJvbGxEaWNlU2NSc3AQ4SoSKwomQ21k";
		buffer[11] = "R2V0Q2hlc3NSb2d1ZVN0b3J5QWVvblRhbGtJbmZvU2NSc3AQnSoSJQogQ21k";
		buffer[12] = "RmluaXNoQ2hlc3NSb2d1ZVN1YlN0b3J5U2NSc3AQiysSIwoeQ21kQ2hlc3NS";
		buffer[13] = "b2d1ZU5vdXNFZGl0RGljZVNjUnNwEKkqEhsKFkNtZENoZXNzUm9ndWVRdWl0";
		buffer[14] = "Q3NSZXEQ8CoSIAobQ21kQ2hlc3NSb2d1ZUVudGVyQ2VsbENzUmVxEKcqEiEK";
		buffer[15] = "HENtZENoZXNzUm9ndWVTZWxlY3RDZWxsU2NSc3AQvCoSIAobQ21kQ2hlc3NS";
		buffer[16] = "b2d1ZUVudGVyQ2VsbFNjUnNwELYrEh0KGENtZEVuaGFuY2VSb2d1ZUJ1ZmZD";
		buffer[17] = "c1JlcRC/KhIrCiZDbWRDaGVzc1JvZ3VlVXBkYXRlVW5sb2NrTGV2ZWxTY05v";
		buffer[18] = "dGlmeRD/KhIiCh1DbWRDaGVzc1JvZ3VlQ29uZmlybVJvbGxTY1JzcBDSKhIl";
		buffer[19] = "CiBDbWRTZWxlY3RDaGVzc1JvZ3VlU3ViU3RvcnlTY1JzcBDpKhIcChdDbWRQ";
		buffer[20] = "aWNrUm9ndWVBdmF0YXJTY1JzcBDEKxIcChdDbWRDaGVzc1JvZ3VlUXVlcnlD";
		buffer[21] = "c1JlcRCkKxIcChdDbWRDaGVzc1JvZ3VlRW50ZXJDc1JlcRCKKxInCiJDbWRH";
		buffer[22] = "ZXRDaGVzc1JvZ3VlTm91c1N0b3J5SW5mb0NzUmVxEKUrEiYKIUNtZENoZXNz";
		buffer[23] = "Um9ndWVOb3VzRGljZVVwZGF0ZU5vdGlmeRDBKhItCihDbWRDaGVzc1JvZ3Vl";
		buffer[24] = "VXBkYXRlTGV2ZWxCYXNlSW5mb1NjTm90aWZ5EMwqEiMKHkNtZEdldENoZXNz";
		buffer[25] = "Um9ndWVTdG9yeUluZm9TY1JzcBDAKhIsCidDbWRDaGVzc1JvZ3VlTm91c0Vu";
		buffer[26] = "YWJsZVJvZ3VlVGFsZW50Q3NSZXEQnysSHAoXQ21kQ2hlc3NSb2d1ZVN0YXJ0";
		buffer[27] = "Q3NSZXEQjCsSLQooQ21kQ2hlc3NSb2d1ZU5vdXNEaWNlU3VyZmFjZVVubG9j";
		buffer[28] = "a05vdGlmeRCOKxIhChxDbWRDaGVzc1JvZ3VlUmVSb2xsRGljZVNjUnNwEJ8q";
		buffer[29] = "Eh0KGENtZENoZXNzUm9ndWVHaXZlVXBDc1JlcRC1KhIgChtDbWRDaGVzc1Jv";
		buffer[30] = "Z3VlQ2hlYXRSb2xsQ3NSZXEQ2CoSGwoWQ21kQ2hlc3NSb2d1ZVF1aXRTY1Jz";
		buffer[31] = "cBD6KhITCg5DbWRMQ0RPQ0tKR0ZDRRCVKxIdChhDbWRDaGVzc1JvZ3VlR2l2";
		buffer[32] = "ZVVwU2NSc3AQsisSKwomQ21kU3luY0NoZXNzUm9ndWVOb3VzTWFpblN0b3J5";
		buffer[33] = "U2NOb3RpZnkQtSsSHwoaQ21kQ2hlc3NSb2d1ZVJvbGxEaWNlQ3NSZXEQ0ysS";
		buffer[34] = "HgoZQ21kUmV2aXZlUm9ndWVBdmF0YXJTY1JzcBDYKxIxCixDbWRDaGVzc1Jv";
		buffer[35] = "Z3VlVXBkYXRlQWxsb3dlZFNlbGVjdENlbGxTY05vdGlmeRCZKhI6CjVDbWRD";
		buffer[36] = "aGVzc1JvZ3VlVXBkYXRlRGljZVBhc3NpdmVBY2N1bXVsYXRlVmFsdWVTY05v";
		buffer[37] = "dGlmeRCmKhIiCh1DbWRDaGVzc1JvZ3VlQ29uZmlybVJvbGxDc1JlcRCHKxId";
		buffer[38] = "ChhDbWRFbmhhbmNlUm9ndWVCdWZmU2NSc3AQhCsSJAofQ21kRW50ZXJDaGVz";
		buffer[39] = "c1JvZ3VlQWVvblJvb21TY1JzcBDDKxIxCixDbWRDaGVzc1JvZ3VlVXBkYXRl";
		buffer[40] = "QWVvbk1vZGlmaWVyVmFsdWVTY05vdGlmeRDSKxItCihDbWRDaGVzc1JvZ3Vl";
		buffer[41] = "Tm91c0dldFJvZ3VlVGFsZW50SW5mb1NjUnNwEK4qEhwKF0NtZFBpY2tSb2d1";
		buffer[42] = "ZUF2YXRhckNzUmVxEJoqEiwKJ0NtZENoZXNzUm9ndWVOb3VzRW5hYmxlUm9n";
		buffer[43] = "dWVUYWxlbnRTY1JzcBDqKhIiCh1DbWRDaGVzc1JvZ3VlQ2VsbFVwZGF0ZU5v";
		buffer[44] = "dGlmeRCFKxIrCiZDbWRDaGVzc1JvZ3VlVXBkYXRlQWN0aW9uUG9pbnRTY05v";
		buffer[45] = "dGlmeRC/KxIgChtDbWRDaGVzc1JvZ3VlQ2hlYXRSb2xsU2NSc3AQkisSLQoo";
		buffer[46] = "Q21kU3luY0NoZXNzUm9ndWVNYWluU3RvcnlGaW5pc2hTY05vdGlmeRCjKhIh";
		buffer[47] = "ChxDbWRDaGVzc1JvZ3VlUmVSb2xsRGljZUNzUmVxEMcrEiUKIENtZEZpbmlz";
		buffer[48] = "aENoZXNzUm9ndWVTdWJTdG9yeUNzUmVxEP4qEigKI0NtZENoZXNzUm9ndWVT";
		buffer[49] = "a2lwVGVhY2hpbmdMZXZlbFNjUnNwEMwrEiMKHkNtZEdldENoZXNzUm9ndWVT";
		buffer[50] = "dG9yeUluZm9Dc1JlcRCTKxIkCh9DbWRFbnRlckNoZXNzUm9ndWVBZW9uUm9v";
		buffer[51] = "bUNzUmVxEKkrEiQKH0NtZEdldFJvZ3VlQnVmZkVuaGFuY2VJbmZvU2NSc3AQ";
		buffer[52] = "qisSKAojQ21kQ2hlc3NSb2d1ZVVwZGF0ZURpY2VJbmZvU2NOb3RpZnkQ5SoS";
		buffer[53] = "IwoeQ21kQ2hlc3NSb2d1ZVF1ZXN0RmluaXNoTm90aWZ5EN4rEiUKIENtZENo";
		buffer[54] = "ZXNzUm9ndWVFbnRlck5leHRMYXllckNzUmVxEP0qEioKJUNtZFN5bmNDaGVz";
		buffer[55] = "c1JvZ3VlTm91c1N1YlN0b3J5U2NOb3RpZnkQlCsSKAojQ21kQ2hlc3NSb2d1";
		buffer[56] = "ZVNraXBUZWFjaGluZ0xldmVsQ3NSZXEQqCoSJAofQ21kR2V0Um9ndWVCdWZm";
		buffer[57] = "RW5oYW5jZUluZm9Dc1JlcRDCKhItCihDbWRDaGVzc1JvZ3VlTm91c0dldFJv";
		buffer[58] = "Z3VlVGFsZW50SW5mb0NzUmVxENcqEhwKF0NtZENoZXNzUm9ndWVMZWF2ZUNz";
		buffer[59] = "UmVxEM4qEhwKF0NtZENoZXNzUm9ndWVTdGFydFNjUnNwEIIrEicKIkNtZFN5";
		buffer[60] = "bmNDaGVzc1JvZ3VlTm91c1ZhbHVlU2NOb3RpZnkQyyoSKwomQ21kR2V0Q2hl";
		buffer[61] = "c3NSb2d1ZVN0b3J5QWVvblRhbGtJbmZvQ3NSZXEQ7yoSJwoiQ21kR2V0Q2hl";
		buffer[62] = "c3NSb2d1ZU5vdXNTdG9yeUluZm9TY1JzcBCkKhIcChdIT0JBRVBLRkZQRF9Q";
		buffer[63] = "R1BETkxMQk1KQhC6KxIhChxDbWRDaGVzc1JvZ3VlU2VsZWN0Q2VsbENzUmVx";
		buffer[64] = "EJ0rEhwKF0hPQkFFUEtGRlBEX0pKUFBKQklLTkJNEM8qEhwKF0NtZENoZXNz";
		buffer[65] = "Um9ndWVFbnRlclNjUnNwENMqEiIKHUNtZFJlc2V0Um9ndWVEaWNlU3VyZmFj";
		buffer[66] = "ZUNzUmVxEL0rQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdChessRogueType) }, null, null));
	}
}
