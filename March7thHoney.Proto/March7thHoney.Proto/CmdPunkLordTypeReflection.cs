using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdPunkLordTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdPunkLordTypeReflection()
	{
		_003C_003Ey__InlineArray22<string> buffer = default(_003C_003Ey__InlineArray22<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray22<string>, string>(ref buffer, 0) = "ChVDbWRQdW5rTG9yZFR5cGUucHJvdG8qgQcKD0NtZFB1bmtMb3JkVHlwZRIb";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray22<string>, string>(ref buffer, 1) = "ChdGS09FR0dDR0xIQV9QQ1BESEVMUEtFTRAAEiQKH0NtZFRha2VQdW5rTG9y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray22<string>, string>(ref buffer, 2) = "ZFBvaW50UmV3YXJkU2NSc3AQpRkSIwoeQ21kR2V0UHVua0xvcmRNb25zdGVy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray22<string>, string>(ref buffer, 3) = "RGF0YVNjUnNwEIoZEiQKH0NtZFB1bmtMb3JkQmF0dGxlUmVzdWx0U2NOb3Rp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray22<string>, string>(ref buffer, 4) = "ZnkQrBkSIQocQ21kU2hhcmVQdW5rTG9yZE1vbnN0ZXJDc1JlcRCOGRIhChxD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray22<string>, string>(ref buffer, 5) = "bWRTaGFyZVB1bmtMb3JkTW9uc3RlclNjUnNwEJIZEiQKH0NtZEdldFB1bmtM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray22<string>, string>(ref buffer, 6) = "b3JkQmF0dGxlUmVjb3JkQ3NSZXEQtRkSKwomQ21kVGFrZUtpbGxlZFB1bmtM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray22<string>, string>(ref buffer, 7) = "b3JkTW9uc3RlclNjb3JlQ3NSZXEQnBkSIwoeQ21kUHVua0xvcmRNb25zdGVy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray22<string>, string>(ref buffer, 8) = "SW5mb1NjTm90aWZ5EIQZEiIKHUNtZFN1bW1vblB1bmtMb3JkTW9uc3RlckNz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray22<string>, string>(ref buffer, 9) = "UmVxEIkZEiMKHkNtZFB1bmtMb3JkTW9uc3RlcktpbGxlZE5vdGlmeRCVGRIc";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray22<string>, string>(ref buffer, 10) = "ChdDbWRHZXRQdW5rTG9yZERhdGFDc1JlcRCmGRIpCiRDbWRHZXRLaWxsZWRQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray22<string>, string>(ref buffer, 11) = "dW5rTG9yZE1vbnN0ZXJEYXRhQ3NSZXEQ5BkSHAoXQ21kR2V0UHVua0xvcmRE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray22<string>, string>(ref buffer, 12) = "YXRhU2NSc3AQyBkSHgoZQ21kU3RhcnRQdW5rTG9yZFJhaWRTY1JzcBDfGRIp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray22<string>, string>(ref buffer, 13) = "CiRDbWRHZXRLaWxsZWRQdW5rTG9yZE1vbnN0ZXJEYXRhU2NSc3AQ2RkSIwoe";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray22<string>, string>(ref buffer, 14) = "Q21kR2V0UHVua0xvcmRNb25zdGVyRGF0YUNzUmVxENsZEiQKH0NtZEdldFB1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray22<string>, string>(ref buffer, 15) = "bmtMb3JkQmF0dGxlUmVjb3JkU2NSc3AQiBkSJAofQ21kVGFrZVB1bmtMb3Jk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray22<string>, string>(ref buffer, 16) = "UG9pbnRSZXdhcmRDc1JlcRDKGRIiCh1DbWRTdW1tb25QdW5rTG9yZE1vbnN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray22<string>, string>(ref buffer, 17) = "ZXJTY1JzcBDiGRIeChlDbWRTdGFydFB1bmtMb3JkUmFpZENzUmVxEN4ZEiAK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray22<string>, string>(ref buffer, 18) = "G0NtZFB1bmtMb3JkRGF0YUNoYW5nZU5vdGlmeRDJGRIjCh5DbWRQdW5rTG9y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray22<string>, string>(ref buffer, 19) = "ZFJhaWRUaW1lT3V0U2NOb3RpZnkQoRkSKwomQ21kVGFrZUtpbGxlZFB1bmtM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray22<string>, string>(ref buffer, 20) = "b3JkTW9uc3RlclNjb3JlU2NSc3AQwRlCFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray22<string>, string>(ref buffer, 21) = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray22<string>, string>(in buffer, 22))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdPunkLordType) }, null, null));
	}
}
