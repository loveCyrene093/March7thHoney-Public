using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdPlayerTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdPlayerTypeReflection()
	{
		_003C_003Ey__InlineArray46<string> buffer = default(_003C_003Ey__InlineArray46<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 0) = "ChNDbWRQbGF5ZXJUeXBlLnByb3RvKsIPCg1DbWRQbGF5ZXJUeXBlEhsKF0xH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 1) = "REVKT05PR0RLX1BDUERIRUxQS0VNEAASGgoWQ21kUGxheWVyR2V0VG9rZW5D";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 2) = "c1JlcRAOEhwKGENtZFF1ZXJ5UHJvZHVjdEluZm9Dc1JlcRBCEhwKGENtZEdl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 3) = "dFNlY3JldEtleUluZm9TY1JzcBBFEhsKF0NtZEV4Y2hhbmdlU3RhbWluYUNz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 4) = "UmVxECUSGwoXTEdERUpPTk9HREtfSlBNUENJS0FNRk8QFxIdChlDbWRQbGF5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 5) = "ZXJMb2dpbkZpbmlzaFNjUnNwED4SEgoOQ21kUEVKUE9BQ0lJS0wQEBISCg5D";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 6) = "bWRHQlBFRUtLTkNPSxBOEhsKF0NtZFBsYXllckhlYXJ0QmVhdENzUmVxEAwS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 7) = "JAogQ21kQ2xpZW50T2JqRG93bmxvYWREYXRhU2NOb3RpZnkQVhIVChFDbWRT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 8) = "ZXRHZW5kZXJTY1JzcBAUEhgKFENtZEdldEJhc2ljSW5mb1NjUnNwECQSFgoS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 9) = "Q21kR2V0QXV0aGtleVNjUnNwEEgSGwoXQ21kQ2xpZW50T2JqVXBsb2FkQ3NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 10) = "ZXEQUBIcChhDbWRNb250aENhcmRSZXdhcmROb3RpZnkQOxIYChRDbWRHZXRC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 11) = "YXNpY0luZm9Dc1JlcRBHEh4KGkNtZEdldFZpZGVvVmVyc2lvbktleVNjUnNw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 12) = "EEQSGgoWQ21kR2V0TGV2ZWxSZXdhcmRTY1JjcBBZEhIKDkNtZEhDQk1JUEZD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 13) = "Q1BMECoSIgoeQ21kUmVzZXJ2ZVN0YW1pbmFFeGNoYW5nZUNzUmVxEA0SEgoO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 14) = "Q21kS0ZHT0tQT0pLUEgQHBIZChVDbWRTZXRQbGF5ZXJJbmZvQ3NSZXEQXRIX";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 15) = "ChNDbWRQbGF5ZXJMb2dpbkNzUmVxEFsSGQoVQ21kU2V0UGxheWVySW5mb1Nj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 16) = "UnNwEAISIwofQ21kR2V0TGV2ZWxSZXdhcmRUYWtlbkxpc3RDc1JlcRA6EhcK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 17) = "E0NtZFBsYXllckxvZ2luU2NSc3AQChIXChNDbWRTZXROaWNrbmFtZUNzUmVx";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 18) = "ED0SEgoOQ21kTUhKQUtHRlBNQ0sQQxIiCh5DbWRGZWF0dXJlU3dpdGNoQ2xv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 19) = "c2VkU2NOb3RpZnkQBhIXChNDbWRTZXROaWNrbmFtZVNjUnNwEAcSHgoaQ21k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 20) = "R2V0VmlkZW9WZXJzaW9uS2V5Q3NSZXEQRhIfChtDbWRTZXRHYW1lcGxheUJp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 21) = "cnRoZGF5Q3NSZXEQXBIiCh5DbWRMaWdodENvbmVSYXJpdHk0QXV0b0xvY2tS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 22) = "ZXEQIxIYChRDbWRHZXRMZXZlbFJld2FyZFJlcRBkEh0KGUNtZFBsYXllclNx";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 23) = "dWVlemVkU2NOb3RpZnkQPxIfChtDbWRTZXRHYW1lcGxheUJpcnRoZGF5U2NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 24) = "c3AQGBIbChdDbWRQbGF5ZXJIZWFydEJlYXRTY1JzcBBNEiIKHkNtZFVwZGF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 25) = "ZUZlYXR1cmVTd2l0Y2hTY05vdGlmeRAeEh8KG0NtZFVwZGF0ZVBsYXllclNl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 26) = "dHRpbmdTY1JzcBAPEhUKEUNtZFNldExhbmd1YWdlUmVxEBUSFgoSQ21kRW50";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 27) = "ZXJTdGFnZUNzUmVxEBoSJAogQ21kRm9yY2VTeW5jR2FtZVN0YXRlRmluaXNo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 28) = "Q1NSZXEQMhIWChJDbWRHZXRBdXRoa2V5Q3NSZXEQJhIZChVDbWREYWlseVJl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 29) = "ZnJlc2hOb3RpZnkQAxISCg5DbWRQSElCR0RGRUZFRRAgEhgKFENtZFBsYXll";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 30) = "ckxvZ291dENzUmVxEF4SGgoWQ21kU3RhbWluYUluZm9TY05vdGlmeRBTEhsK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 31) = "F0xHREVKT05PR0RLX01ER0FJQ0ZCQ0tKEC8SEgoOQ21kTUhKT0pFRkVPS0sQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 32) = "KBISCg5DbWROQkNES0FPRk5NRBBiEhsKF0xHREVKT05PR0RLX09PT0lFSElD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 33) = "TURNEF8SHAoYQ21kR2V0U2VjcmV0S2V5SW5mb0NzUmVxEFoSGwoXQ21kQ2xp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 34) = "ZW50T2JqVXBsb2FkU2NSc3AQVRIiCh5DbWRSZXNlcnZlU3RhbWluYUV4Y2hh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 35) = "bmdlU2NSc3AQHxISCg5DbWRIREVGUEJOTk1EShBREhIKDkNtZENJQUFOTUNQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 36) = "QkdGEB0SEgoOQ21kRERDQ0tEQ0VCT0oQExISCg5DbWRQREFOT0hCS0JCRhAn";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 37) = "EhsKF0NtZEV4Y2hhbmdlU3RhbWluYVNjUnNwEAQSIwofQ21kR2V0TGV2ZWxS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 38) = "ZXdhcmRUYWtlbkxpc3RTY1JzcBAsEigKJENtZFVwZGF0ZVBsYXlXaXRoUHNu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 39) = "T25seVNldHRpbmdDc1JlcRA3EhUKEUNtZFNldEdlbmRlckNzUmVxEE8SIAoc";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 40) = "Q21kU2V0UmVkUG9pbnRTdGF0dXNTY05vdGlmeRBSEhsKF0NtZFNlcnZlckFu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 41) = "bm91bmNlTm90aWZ5EEESHQoZQ21kUGxheWVyTG9naW5GaW5pc2hDc1JlcRAp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 42) = "EhwKGENtZFF1ZXJ5UHJvZHVjdEluZm9TY1JzcBAFEhkKFUNtZEFudGlBZGRp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 43) = "Y3RTY05vdGlmeRAhEiEKHUNtZENsaWVudERvd25sb2FkRGF0YVNjTm90aWZ5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 44) = "EAsSGgoWQ21kUGxheWVyR2V0VG9rZW5TY1JzcBASQhaqAhNNYXJjaDd0aEhv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 45) = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray46<string>, string>(in buffer, 46))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdPlayerType) }, null, null));
	}
}
