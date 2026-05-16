using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdHeliobusTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdHeliobusTypeReflection()
	{
		_003C_003Ey__InlineArray20<string> buffer = default(_003C_003Ey__InlineArray20<string>);
		buffer[0] = "ChVDbWRIZWxpb2J1c1R5cGUucHJvdG8qsAYKD0NtZEhlbGlvYnVzVHlwZRIb";
		buffer[1] = "ChdNSk5CRE9EUERPR19QQ1BESEVMUEtFTRAAEhwKF0NtZEhlbGlvYnVzU25z";
		buffer[2] = "UmVhZFNjUnNwEIcuEhwKF0NtZEhlbGlvYnVzU25zUG9zdENzUmVxELYtEiAK";
		buffer[3] = "G0NtZEhlbGlvYnVzRW50ZXJCYXR0bGVDc1JlcRDlLRIfChpDbWRIZWxpb2J1";
		buffer[4] = "c1Nuc0NvbW1lbnRDc1JlcRDnLRIcChdDbWRIZWxpb2J1c1Nuc0xpa2VDc1Jl";
		buffer[5] = "cRCxLRIcChdNSk5CRE9EUERPR19HRkhHTk5IT0lLShDOLRIjCh5DbWRIZWxp";
		buffer[6] = "b2J1c1VubG9ja1NraWxsU2NOb3RpZnkQrC0SHAoXQ21kSGVsaW9idXNTbnNM";
		buffer[7] = "aWtlU2NSc3AQii4SIwoeQ21kSGVsaW9idXNJbmZvQ2hhbmdlZFNjTm90aWZ5";
		buffer[8] = "EKktEhwKF0NtZEhlbGlvYnVzU25zUG9zdFNjUnNwELotEiEKHENtZEhlbGlv";
		buffer[9] = "YnVzQWN0aXZpdHlEYXRhU2NSc3AQsi0SHAoXQ21kSGVsaW9idXNTbnNSZWFk";
		buffer[10] = "Q3NSZXEQhi4SIQocQ21kSGVsaW9idXNBY3Rpdml0eURhdGFDc1JlcRCDLhIh";
		buffer[11] = "ChxDbWRIZWxpb2J1c1Nuc1VwZGF0ZVNjTm90aWZ5EM8tEiAKG0NtZEhlbGlv";
		buffer[12] = "YnVzRW50ZXJCYXR0bGVTY1JzcBCvLRIkCh9DbWRIZWxpb2J1c0xpbmV1cFVw";
		buffer[13] = "ZGF0ZVNjTm90aWZ5EIEuEicKIkNtZEhlbGlvYnVzQ2hhbGxlbmdlVXBkYXRl";
		buffer[14] = "U2NOb3RpZnkQjC4SIQocQ21kSGVsaW9idXNVcGdyYWRlTGV2ZWxDc1JlcRDy";
		buffer[15] = "LRIeChlDbWRIZWxpb2J1c1N0YXJ0UmFpZFNjUnNwENQtEiEKHENtZEhlbGlv";
		buffer[16] = "YnVzVXBncmFkZUxldmVsU2NSc3AQzS0SHgoZQ21kSGVsaW9idXNTdGFydFJh";
		buffer[17] = "aWRDc1JlcRDiLRIfChpDbWRIZWxpb2J1c1Nuc0NvbW1lbnRTY1JzcBDCLRIg";
		buffer[18] = "ChtDbWRIZWxpb2J1c1NlbGVjdFNraWxsU2NSc3AQ8C1CFqoCE01hcmNoN3Ro";
		buffer[19] = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdHeliobusType) }, null, null));
	}
}
