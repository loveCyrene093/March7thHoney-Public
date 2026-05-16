using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdPlayerReturnTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdPlayerReturnTypeReflection()
	{
		_003C_003Ey__InlineArray20<string> buffer = default(_003C_003Ey__InlineArray20<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 0) = "ChlDbWRQbGF5ZXJSZXR1cm5UeXBlLnByb3RvKroGChNDbWRQbGF5ZXJSZXR1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 1) = "cm5UeXBlEhsKF0dLSVBNSU1QRExFX1BDUERIRUxQS0VNEAASKAojQ21kUGxh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 2) = "eWVyUmV0dXJuVGFrZVBvaW50UmV3YXJkQ3NSZXEQoiMSJwoiQ21kVGFrZVJl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 3) = "dHVybkV4dHJhSGNvaW5SZXdhcmRDc1JlcRC1IxInCiJDbWRUYWtlUmV0dXJu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 4) = "RXh0cmFIY29pblJld2FyZFNjUnNwENEjEiIKHUNtZFBsYXllclJldHVybklu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 5) = "Zm9RdWVyeVNjUnNwEK4jEicKIkNtZFBsYXllclJldHVyblBvaW50Q2hhbmdl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 6) = "U2NOb3RpZnkQ8yMSHAoXR0tJUE1JTVBETEVfTUtBTkxCQUdHRU8QziMSKgol";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 7) = "Q21kUGxheWVyUmV0dXJuVGFrZUV4dHJhSGNvaW5TY05vdGlmeRC5IxIuCilD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 8) = "bWRQbGF5ZXJSZXR1cm5FeHRyYUhjb2luUHJvZ3Jlc3NTY05vdGlmeRCbIxId";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 9) = "ChhDbWRQbGF5ZXJSZXR1cm5TaWduQ3NSZXEQniMSEwoOQ21kSElCTE1ETlBP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 10) = "TU4Q7yMSIgodQ21kUGxheWVyUmV0dXJuSW5mb1F1ZXJ5Q3NSZXEQ0yMSIgod";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 11) = "Q21kUGxheWVyUmV0dXJuVGFrZVJlbGljU2NSc3AQ3iMSKAojQ21kUGxheWVy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 12) = "UmV0dXJuVGFrZVBvaW50UmV3YXJkU2NSc3AQpiMSIgodQ21kUGxheWVyUmV0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 13) = "dXJuVGFrZVJlbGljQ3NSZXEQlSMSKAojQ21kUGxheWVyUmV0dXJuVGFrZUN1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 14) = "c3RvbVJlbGljQ3NSZXEQmCMSKAojQ21kUGxheWVyUmV0dXJuVGFrZUN1c3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 15) = "bVJlbGljU2NSc3AQuiMSEwoOQ21kTkVPQURNRUFJREsQwCMSIwoeQ21kUGxh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 16) = "eWVyUmV0dXJuVGFrZVJld2FyZENzUmVxEJ0jEh0KGENtZFBsYXllclJldHVy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 17) = "blNpZ25TY1JzcBDyIxIjCh5DbWRQbGF5ZXJSZXR1cm5UYWtlUmV3YXJkU2NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 18) = "c3AQ9iMSJwoiQ21kUGxheWVyUmV0dXJuRm9yY2VGaW5pc2hTY05vdGlmeRC7";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 19) = "I0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray20<string>, string>(in buffer, 20))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdPlayerReturnType) }, null, null));
	}
}
