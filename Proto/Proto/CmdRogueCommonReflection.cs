using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdRogueCommonReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdRogueCommonReflection()
	{
		_003C_003Ey__InlineArray52<string> buffer = default(_003C_003Ey__InlineArray52<string>);
		buffer[0] = "ChRDbWRSb2d1ZUNvbW1vbi5wcm90byriEQoOQ21kUm9ndWVDb21tb24SGwoX";
		buffer[1] = "Q0FOT0hQR1BDR0pfQlBOS05DTEFLQUcQABIfChpDbWRSb2d1ZUdldEdhbWJs";
		buffer[2] = "ZUluZm9TY1JzcBCrLBIcChdDQU5PSFBHUENHSl9MT0FBTUpCSUVPSBCaLBIh";
		buffer[3] = "ChxDbWRSb2d1ZVNob3BCZWdpbkJhdHRsZUNzUmVxEJIsEhMKDkNtZFBMSEdC";
		buffer[4] = "TEtKTk9MEMIsEh8KGkNtZFNldFJvZ3VlQ29sbGVjdGlvblNjUnNwEO0rEhMK";
		buffer[5] = "DkNtZE9PQ09NSU9QSU5NEPorEisKJkNtZFRha2VSb2d1ZU1pcmFjbGVIYW5k";
		buffer[6] = "Ym9va1Jld2FyZFNjUnNwEOIrEiUKIENtZFJvZ3VlV29ya2JlbmNoSGFuZGxl";
		buffer[7] = "RnVuY1NjUnNwEJwsEiwKJ0NtZFNlbGVjdFJvZ3VlQ29tbW9uRGlhbG9ndWVP";
		buffer[8] = "cHRpb25TY1JzcBC4LBIkCh9DbWRUYWtlRXZlbnRIYW5kYm9va1Jld2FyZFNj";
		buffer[9] = "UnNwEKIsEiEKHENtZEdldFJvZ3VlU2hvcEJ1ZmZJbmZvU2NSc3AQ6SsSHwoa";
		buffer[10] = "Q21kU2V0Um9ndWVFeGhpYml0aW9uU2NSc3AQsywSHwoaQ21kUm9ndWVHZXRH";
		buffer[11] = "YW1ibGVJbmZvQ3NSZXEQwSwSJwoiQ21kR2V0Um9ndWVDb21tb25EaWFsb2d1";
		buffer[12] = "ZURhdGFTY1JzcBDwKxIaChVDbWRSb2d1ZURvR2FtYmxlQ3NSZXEQkCwSHQoY";
		buffer[13] = "Q21kQ29tbW9uUm9ndWVRdWVyeVNjUnNwEP0rEhwKF0NBTk9IUEdQQ0dKX0lB";
		buffer[14] = "TUNOQ0lFSEdHEIwsEiIKHUNtZFJvZ3VlV29ya2JlbmNoR2V0SW5mb0NzUmVx";
		buffer[15] = "EKYsEisKJkNtZEhhbmRsZVJvZ3VlQ29tbW9uUGVuZGluZ0FjdGlvblNjUnNw";
		buffer[16] = "EIosEiQKH0NtZEdldFJvZ3VlU2hvcE1pcmFjbGVJbmZvU2NSc3AQ7isSEwoO";
		buffer[17] = "Q21kRkhFS1BJQUdOSU4QuiwSIQocQ21kUm9ndWVTaG9wQmVnaW5CYXR0bGVT";
		buffer[18] = "Y1JzcBDzKxIkCh9DbWRHZXRSb2d1ZVNob3BGb3JtdWxhSW5mb1NjUnNwEPsr";
		buffer[19] = "Eh0KGENtZEJ1eVJvZ3VlU2hvcEJ1ZmZTY1JzcBCHLBITCg5DbWRORUVMTkFC";
		buffer[20] = "SlBHRRC+LBIbChZDbWRTZWxlY3RSb2d1ZUJvbnVzUmVxEK4sEiwKJ0NtZFN5";
		buffer[21] = "bmNSb2d1ZUNvbW1vblBlbmRpbmdBY3Rpb25TY05vdGlmeRDrKxIqCiVDbWRD";
		buffer[22] = "b21tb25Sb2d1ZVZpcnR1YWxJdGVtSW5mb1NjTm90aWZ5EIQsEhMKDkNtZElB";
		buffer[23] = "R0ZMRUJCT0dCEKosEhMKDkNtZExIRUZISkxCSEdLEMAsEiQKH0NtZEdldFJv";
		buffer[24] = "Z3VlU2hvcE1pcmFjbGVJbmZvQ3NSZXEQvywSGgoVQ21kUm9ndWVEb0dhbWJs";
		buffer[25] = "ZVNjUnNwEKwsEioKJUNtZFVwZGF0ZVJvZ3VlQWR2ZW50dXJlUm9vbVNjb3Jl";
		buffer[26] = "Q3NSZXEQ/isSIAobQ21kQnV5Um9ndWVTaG9wTWlyYWNsZUNzUmVxEPcrEh8K";
		buffer[27] = "GkNtZFNldFJvZ3VlRXhoaWJpdGlvbkNzUmVxEP8rEiEKHENtZEdldFJvZ3Vl";
		buffer[28] = "U2hvcEJ1ZmZJbmZvQ3NSZXEQ8isSLAonQ21kU2VsZWN0Um9ndWVDb21tb25E";
		buffer[29] = "aWFsb2d1ZU9wdGlvbkNzUmVxEOYrEiQKH0NtZFRha2VFdmVudEhhbmRib29r";
		buffer[30] = "UmV3YXJkQ3NSZXEQkSwSIAobQ21kQnV5Um9ndWVTaG9wRm9ybXVsYVNjUnNw";
		buffer[31] = "EKMsEicKIkNtZEdldFJvZ3VlQ29tbW9uRGlhbG9ndWVEYXRhQ3NSZXEQrSwS";
		buffer[32] = "KwomQ21kVGFrZVJvZ3VlTWlyYWNsZUhhbmRib29rUmV3YXJkQ3NSZXEQvSwS";
		buffer[33] = "JAofQ21kUm9ndWVXb3JrYmVuY2hSZWZvcmdlQnVmZlJlcRCyLBIgChtDbWRC";
		buffer[34] = "dXlSb2d1ZVNob3BNaXJhY2xlU2NSc3AQnywSHAoXQ0FOT0hQR1BDR0pfTkJF";
		buffer[35] = "RUVORkZFTUUQ5ysSHQoYQ21kQ29tbW9uUm9ndWVRdWVyeUNzUmVxEJssEiYK";
		buffer[36] = "IUNtZFByZXBhcmVSb2d1ZUFkdmVudHVyZVJvb21Dc1JlcRDqKxITCg5DbWRJ";
		buffer[37] = "RlBLRVBJQU9GUBC7LBIiCh1DbWRSb2d1ZVdvcmtiZW5jaEdldEluZm9TY1Jz";
		buffer[38] = "cBCkLBIrCiZDbWRTeW5jUm9ndWVDb21tb25EaWFsb2d1ZURhdGFTY05vdGlm";
		buffer[39] = "eRClLBITCg5DbWRFSkdIS0ZESEdHQxDkKxIhChxDbWRHZXRSb2d1ZUhhbmRi";
		buffer[40] = "b29rRGF0YUNzUmVxEJYsEhMKDkNtZE5ESEZIRkZISklIEKcsEiEKHENtZEdl";
		buffer[41] = "dFJvZ3VlSGFuZGJvb2tEYXRhU2NSc3AQrywSHwoaQ21kU2V0Um9ndWVDb2xs";
		buffer[42] = "ZWN0aW9uQ3NSZXEQwywSHgoZQ21kUm9ndWVOcGNEaXNhcHBlYXJDc1JlcRDh";
		buffer[43] = "KxIzCi5DbWRTeW5jUm9ndWVDb21tb25EaWFsb2d1ZU9wdGlvbkZpbmlzaFNj";
		buffer[44] = "Tm90aWZ5EIksEiYKIUNtZEdldFJvZ3VlQWR2ZW50dXJlUm9vbUluZm9Dc1Jl";
		buffer[45] = "cRCFLBIrCiZDbWRTeW5jUm9ndWVDb21tb25BY3Rpb25SZXN1bHRTY05vdGlm";
		buffer[46] = "eRDlKxIhChxDbWRDb21tb25Sb2d1ZVVwZGF0ZVNjTm90aWZ5EOwrEiQKH0Nt";
		buffer[47] = "ZEdldFJvZ3VlU2hvcEZvcm11bGFJbmZvQ3NSZXEQtywSKwomQ21kU3luY1Jv";
		buffer[48] = "Z3VlSGFuZGJvb2tEYXRhVXBkYXRlU2NOb3RpZnkQ9CsSJgohQ21kRmluaXNo";
		buffer[49] = "Um9ndWVDb21tb25EaWFsb2d1ZUNzUmVxEJQsEiMKHkNtZFN0b3BSb2d1ZUFk";
		buffer[50] = "dmVudHVyZVJvb21Dc1JlcRC5LBIcChdDQU5PSFBHUENHSl9MTEFFRU9IRlBF";
		buffer[51] = "RBDELEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdRogueCommon) }, null, null));
	}
}
