using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdCakeRaceTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdCakeRaceTypeReflection()
	{
		_003C_003Ey__InlineArray20<string> buffer = default(_003C_003Ey__InlineArray20<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 0) = "ChVDbWRDYWtlUmFjZVR5cGUucHJvdG8qoQYKD0NtZENha2VSYWNlVHlwZRIb";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 1) = "ChdFTUJMR0hNRkdFQV9QQ1BESEVMUEtFTRAAEhwKF0NtZENha2VSYWNlR2V0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 2) = "RGF0YVNjUnNwELJHEhkKFENtZENha2VSYWNlTG9hbkNzUmVxEKRHEiAKG0Nt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 3) = "ZENha2VSYWNlR2V0SGFuZGJvb2tTY1JzcBCqRxITCg5DbWRDTU5MSUVLQkZO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 4) = "ShCtRxIcChdDbWRDYWtlUmFjZUdldERhdGFDc1JlcRCiRxITCg5DbWRCUExE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 5) = "SERGRElEQRC5RxIeChlDbWRDYWtlUmFjZUZpbmlzaFB2ZUNzUmVxELtHEikK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 6) = "JENtZENha2VSYWNlRmluaXNoRmllbGRSZXdhcmRTY05vdGlmeRC9RxIeChlD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 7) = "bWRDYWtlUmFjZVVwZGF0ZVB2ZVNjUnNwEK9HEiEKHENtZENha2VSYWNlR2V0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 8) = "RGFpbHlMaWtlQ3NSZXEQukcSJwoiQ21kQ2FrZVJhY2VDb2luU2NvcmVDaGFu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 9) = "Z2VTY05vdGlmeRC2RxItCihDbWRDYWtlUmFjZUdldEZyaWVuZFJhbmtpbmdJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 10) = "bmZvTGlzdFNjUnNwELRHEhkKFENtZENha2VSYWNlTG9hblNjUnNwELNHEi0K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 11) = "KENtZENha2VSYWNlR2V0RnJpZW5kUmFua2luZ0luZm9MaXN0Q3NSZXEQt0cS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 12) = "KgolQ21kQ2FrZVJhY2VMaWtlRnJpZW5kUmFua2luZ0luZm9TY1JzcBCuRxId";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 13) = "ChhDbWRDYWtlUmFjZVN0YXJ0UHZlQ3NSZXEQo0cSIQocQ21kQ2FrZVJhY2VH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 14) = "ZXREYWlseUxpa2VTY1JzcBCnRxIcChdFTUJMR0hNRkdFQV9GR0NGR05OREhP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 15) = "RhCxRxIdChhDbWRDYWtlUmFjZVN0YXJ0UHZlU2NSc3AQoUcSJQogQ21kQ2Fr";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 16) = "ZVJhY2VVcGRhdGVQdmVNZWV0Q2F0Q3NSZXEQvkcSIAobQ21kQ2FrZVJhY2VH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 17) = "ZXRIYW5kYm9va0NzUmVxEKtHEioKJUNtZENha2VSYWNlTGlrZUZyaWVuZFJh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 18) = "bmtpbmdJbmZvQ3NSZXEQqUdCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 19) = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray20<string>, string>(in buffer, 20))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdCakeRaceType) }, null, null));
	}
}
