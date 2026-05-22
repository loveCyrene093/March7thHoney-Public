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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 0) = "ChRDbWRSb2d1ZUNvbW1vbi5wcm90byriEQoOQ21kUm9ndWVDb21tb24SGwoX";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 1) = "Q0FOT0hQR1BDR0pfQlBOS05DTEFLQUcQABIfChpDbWRSb2d1ZUdldEdhbWJs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 2) = "ZUluZm9TY1JzcBCrLBIcChdDQU5PSFBHUENHSl9MT0FBTUpCSUVPSBCaLBIh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 3) = "ChxDbWRSb2d1ZVNob3BCZWdpbkJhdHRsZUNzUmVxEJIsEhMKDkNtZFBMSEdC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 4) = "TEtKTk9MEMIsEh8KGkNtZFNldFJvZ3VlQ29sbGVjdGlvblNjUnNwEO0rEhMK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 5) = "DkNtZE9PQ09NSU9QSU5NEPorEisKJkNtZFRha2VSb2d1ZU1pcmFjbGVIYW5k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 6) = "Ym9va1Jld2FyZFNjUnNwEOIrEiUKIENtZFJvZ3VlV29ya2JlbmNoSGFuZGxl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 7) = "RnVuY1NjUnNwEJwsEiwKJ0NtZFNlbGVjdFJvZ3VlQ29tbW9uRGlhbG9ndWVP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 8) = "cHRpb25TY1JzcBC4LBIkCh9DbWRUYWtlRXZlbnRIYW5kYm9va1Jld2FyZFNj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 9) = "UnNwEKIsEiEKHENtZEdldFJvZ3VlU2hvcEJ1ZmZJbmZvU2NSc3AQ6SsSHwoa";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 10) = "Q21kU2V0Um9ndWVFeGhpYml0aW9uU2NSc3AQsywSHwoaQ21kUm9ndWVHZXRH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 11) = "YW1ibGVJbmZvQ3NSZXEQwSwSJwoiQ21kR2V0Um9ndWVDb21tb25EaWFsb2d1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 12) = "ZURhdGFTY1JzcBDwKxIaChVDbWRSb2d1ZURvR2FtYmxlQ3NSZXEQkCwSHQoY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 13) = "Q21kQ29tbW9uUm9ndWVRdWVyeVNjUnNwEP0rEhwKF0NBTk9IUEdQQ0dKX0lB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 14) = "TUNOQ0lFSEdHEIwsEiIKHUNtZFJvZ3VlV29ya2JlbmNoR2V0SW5mb0NzUmVx";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 15) = "EKYsEisKJkNtZEhhbmRsZVJvZ3VlQ29tbW9uUGVuZGluZ0FjdGlvblNjUnNw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 16) = "EIosEiQKH0NtZEdldFJvZ3VlU2hvcE1pcmFjbGVJbmZvU2NSc3AQ7isSEwoO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 17) = "Q21kRkhFS1BJQUdOSU4QuiwSIQocQ21kUm9ndWVTaG9wQmVnaW5CYXR0bGVT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 18) = "Y1JzcBDzKxIkCh9DbWRHZXRSb2d1ZVNob3BGb3JtdWxhSW5mb1NjUnNwEPsr";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 19) = "Eh0KGENtZEJ1eVJvZ3VlU2hvcEJ1ZmZTY1JzcBCHLBITCg5DbWRORUVMTkFC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 20) = "SlBHRRC+LBIbChZDbWRTZWxlY3RSb2d1ZUJvbnVzUmVxEK4sEiwKJ0NtZFN5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 21) = "bmNSb2d1ZUNvbW1vblBlbmRpbmdBY3Rpb25TY05vdGlmeRDrKxIqCiVDbWRD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 22) = "b21tb25Sb2d1ZVZpcnR1YWxJdGVtSW5mb1NjTm90aWZ5EIQsEhMKDkNtZElB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 23) = "R0ZMRUJCT0dCEKosEhMKDkNtZExIRUZISkxCSEdLEMAsEiQKH0NtZEdldFJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 24) = "Z3VlU2hvcE1pcmFjbGVJbmZvQ3NSZXEQvywSGgoVQ21kUm9ndWVEb0dhbWJs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 25) = "ZVNjUnNwEKwsEioKJUNtZFVwZGF0ZVJvZ3VlQWR2ZW50dXJlUm9vbVNjb3Jl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 26) = "Q3NSZXEQ/isSIAobQ21kQnV5Um9ndWVTaG9wTWlyYWNsZUNzUmVxEPcrEh8K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 27) = "GkNtZFNldFJvZ3VlRXhoaWJpdGlvbkNzUmVxEP8rEiEKHENtZEdldFJvZ3Vl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 28) = "U2hvcEJ1ZmZJbmZvQ3NSZXEQ8isSLAonQ21kU2VsZWN0Um9ndWVDb21tb25E";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 29) = "aWFsb2d1ZU9wdGlvbkNzUmVxEOYrEiQKH0NtZFRha2VFdmVudEhhbmRib29r";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 30) = "UmV3YXJkQ3NSZXEQkSwSIAobQ21kQnV5Um9ndWVTaG9wRm9ybXVsYVNjUnNw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 31) = "EKMsEicKIkNtZEdldFJvZ3VlQ29tbW9uRGlhbG9ndWVEYXRhQ3NSZXEQrSwS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 32) = "KwomQ21kVGFrZVJvZ3VlTWlyYWNsZUhhbmRib29rUmV3YXJkQ3NSZXEQvSwS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 33) = "JAofQ21kUm9ndWVXb3JrYmVuY2hSZWZvcmdlQnVmZlJlcRCyLBIgChtDbWRC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 34) = "dXlSb2d1ZVNob3BNaXJhY2xlU2NSc3AQnywSHAoXQ0FOT0hQR1BDR0pfTkJF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 35) = "RUVORkZFTUUQ5ysSHQoYQ21kQ29tbW9uUm9ndWVRdWVyeUNzUmVxEJssEiYK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 36) = "IUNtZFByZXBhcmVSb2d1ZUFkdmVudHVyZVJvb21Dc1JlcRDqKxITCg5DbWRJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 37) = "RlBLRVBJQU9GUBC7LBIiCh1DbWRSb2d1ZVdvcmtiZW5jaEdldEluZm9TY1Jz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 38) = "cBCkLBIrCiZDbWRTeW5jUm9ndWVDb21tb25EaWFsb2d1ZURhdGFTY05vdGlm";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 39) = "eRClLBITCg5DbWRFSkdIS0ZESEdHQxDkKxIhChxDbWRHZXRSb2d1ZUhhbmRi";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 40) = "b29rRGF0YUNzUmVxEJYsEhMKDkNtZE5ESEZIRkZISklIEKcsEiEKHENtZEdl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 41) = "dFJvZ3VlSGFuZGJvb2tEYXRhU2NSc3AQrywSHwoaQ21kU2V0Um9ndWVDb2xs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 42) = "ZWN0aW9uQ3NSZXEQwywSHgoZQ21kUm9ndWVOcGNEaXNhcHBlYXJDc1JlcRDh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 43) = "KxIzCi5DbWRTeW5jUm9ndWVDb21tb25EaWFsb2d1ZU9wdGlvbkZpbmlzaFNj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 44) = "Tm90aWZ5EIksEiYKIUNtZEdldFJvZ3VlQWR2ZW50dXJlUm9vbUluZm9Dc1Jl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 45) = "cRCFLBIrCiZDbWRTeW5jUm9ndWVDb21tb25BY3Rpb25SZXN1bHRTY05vdGlm";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 46) = "eRDlKxIhChxDbWRDb21tb25Sb2d1ZVVwZGF0ZVNjTm90aWZ5EOwrEiQKH0Nt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 47) = "ZEdldFJvZ3VlU2hvcEZvcm11bGFJbmZvQ3NSZXEQtywSKwomQ21kU3luY1Jv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 48) = "Z3VlSGFuZGJvb2tEYXRhVXBkYXRlU2NOb3RpZnkQ9CsSJgohQ21kRmluaXNo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 49) = "Um9ndWVDb21tb25EaWFsb2d1ZUNzUmVxEJQsEiMKHkNtZFN0b3BSb2d1ZUFk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 50) = "dmVudHVyZVJvb21Dc1JlcRC5LBIcChdDQU5PSFBHUENHSl9MTEFFRU9IRlBF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray52<string>, string>(ref buffer, 51) = "RBDELEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray52<string>, string>(in buffer, 52))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdRogueCommon) }, null, null));
	}
}
