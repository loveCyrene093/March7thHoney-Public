using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdSwordTrainingTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdSwordTrainingTypeReflection()
	{
		_003C_003Ey__InlineArray35<string> buffer = default(_003C_003Ey__InlineArray35<string>);
		buffer[0] = "ChpDbWRTd29yZFRyYWluaW5nVHlwZS5wcm90byrlCwoUQ21kU3dvcmRUcmFp";
		buffer[1] = "bmluZ1R5cGUSGwoXS0tQUEpFTlBBSkNfUENQREhFTFBLRU0QABIkCh9DbWRT";
		buffer[2] = "d29yZFRyYWluaW5nR2l2ZVVwR2FtZVNjUnNwEKA6EioKJUNtZFN3b3JkVHJh";
		buffer[3] = "aW5pbmdNYXJrRW5kaW5nVmlld2VkU2NSc3AQpToSJAofQ21kU3dvcmRUcmFp";
		buffer[4] = "bmluZ1R1cm5BY3Rpb25TY1JzcBC9OhIkCh9DbWRTd29yZFRyYWluaW5nTGVh";
		buffer[5] = "cm5Ta2lsbENzUmVxEJ06EisKJkNtZFN3b3JkVHJhaW5pbmdHYW1lU3luY0No";
		buffer[6] = "YW5nZVNjTm90aWZ5EKc6EiEKHENtZEdldFN3b3JkVHJhaW5pbmdEYXRhQ3NS";
		buffer[7] = "ZXEQoToSJgohQ21kU3dvcmRUcmFpbmluZ1NlbGVjdEVuZGluZ0NzUmVxEL86";
		buffer[8] = "EicKIkNtZFN3b3JkVHJhaW5pbmdTZXRTa2lsbFRyYWNlQ3NSZXEQsjoSLQoo";
		buffer[9] = "Q21kU3dvcmRUcmFpbmluZ0FjdGlvblR1cm5TZXR0bGVTY05vdGlmeRCwOhIk";
		buffer[10] = "Ch9DbWRTd29yZFRyYWluaW5nUmVzdW1lR2FtZVNjUnNwELw6EiUKIENtZFN3";
		buffer[11] = "b3JkVHJhaW5pbmdTdG9yeUJhdHRsZUNzUmVxELE6EiQKH0NtZFN3b3JkVHJh";
		buffer[12] = "aW5pbmdHaXZlVXBHYW1lQ3NSZXEQqToSJAofQ21kU3dvcmRUcmFpbmluZ0xl";
		buffer[13] = "YXJuU2tpbGxTY1JzcBDMOhIjCh5DbWRFbnRlclN3b3JkVHJhaW5pbmdFeGFt";
		buffer[14] = "Q3NSZXEQxzoSLgopQ21kU3dvcmRUcmFpbmluZ0RpYWxvZ3VlU2VsZWN0T3B0";
		buffer[15] = "aW9uU2NSc3AQyToSJgohQ21kU3dvcmRUcmFpbmluZ1N0b3J5Q29uZmlybVNj";
		buffer[16] = "UnNwEMs6EiUKIENtZFN3b3JkVHJhaW5pbmdTdG9yeUJhdHRsZVNjUnNwEKg6";
		buffer[17] = "EisKJkNtZFN3b3JkVHJhaW5pbmdFeGFtUmVzdWx0Q29uZmlybVNjUnNwEMI6";
		buffer[18] = "EiYKIUNtZFN3b3JkVHJhaW5pbmdTdG9yeUNvbmZpcm1Dc1JlcRCvOhIkCh9D";
		buffer[19] = "bWRTd29yZFRyYWluaW5nVHVybkFjdGlvbkNzUmVxELU6EisKJkNtZFN3b3Jk";
		buffer[20] = "VHJhaW5pbmdFeGFtUmVzdWx0Q29uZmlybUNzUmVxEMg6EicKIkNtZFN3b3Jk";
		buffer[21] = "VHJhaW5pbmdTZXRTa2lsbFRyYWNlU2NSc3AQwzoSJQogQ21kU3dvcmRUcmFp";
		buffer[22] = "bmluZ1Jlc3RvcmVHYW1lU2NSc3AQrjoSJgohQ21kU3dvcmRUcmFpbmluZ1Nl";
		buffer[23] = "bGVjdEVuZGluZ1NjUnNwEMo6EiMKHkNtZEVudGVyU3dvcmRUcmFpbmluZ0V4";
		buffer[24] = "YW1TY1JzcBC+OhIkCh9DbWRTd29yZFRyYWluaW5nUmVzdW1lR2FtZUNzUmVx";
		buffer[25] = "EKY6EiMKHkNtZFN3b3JkVHJhaW5pbmdTdGFydEdhbWVTY1JzcBC5OhIuCilD";
		buffer[26] = "bWRTd29yZFRyYWluaW5nRGlhbG9ndWVTZWxlY3RPcHRpb25Dc1JlcRCbOhIr";
		buffer[27] = "CiZDbWRTd29yZFRyYWluaW5nRGFpbHlQaGFzZUNvbmZpcm1TY1JzcBCfOhIn";
		buffer[28] = "CiJDbWRTd29yZFRyYWluaW5nVW5sb2NrU3luY1NjTm90aWZ5ELs6EiMKHkNt";
		buffer[29] = "ZFN3b3JkVHJhaW5pbmdTdGFydEdhbWVDc1JlcRCqOhIrCiZDbWRTd29yZFRy";
		buffer[30] = "YWluaW5nRGFpbHlQaGFzZUNvbmZpcm1Dc1JlcRDAOhIlCiBDbWRTd29yZFRy";
		buffer[31] = "YWluaW5nUmVzdG9yZUdhbWVDc1JlcRDBOhIhChxDbWRHZXRTd29yZFRyYWlu";
		buffer[32] = "aW5nRGF0YVNjUnNwELg6EicKIkNtZFN3b3JkVHJhaW5pbmdHYW1lU2V0dGxl";
		buffer[33] = "U2NOb3RpZnkQojoSKgolQ21kU3dvcmRUcmFpbmluZ01hcmtFbmRpbmdWaWV3";
		buffer[34] = "ZWRDc1JlcRDEOkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdSwordTrainingType) }, null, null));
	}
}
