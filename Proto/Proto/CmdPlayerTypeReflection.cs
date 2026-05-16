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
		buffer[0] = "ChNDbWRQbGF5ZXJUeXBlLnByb3RvKsIPCg1DbWRQbGF5ZXJUeXBlEhsKF0xH";
		buffer[1] = "REVKT05PR0RLX1BDUERIRUxQS0VNEAASGgoWQ21kUGxheWVyR2V0VG9rZW5D";
		buffer[2] = "c1JlcRAOEhwKGENtZFF1ZXJ5UHJvZHVjdEluZm9Dc1JlcRBCEhwKGENtZEdl";
		buffer[3] = "dFNlY3JldEtleUluZm9TY1JzcBBFEhsKF0NtZEV4Y2hhbmdlU3RhbWluYUNz";
		buffer[4] = "UmVxECUSGwoXTEdERUpPTk9HREtfSlBNUENJS0FNRk8QFxIdChlDbWRQbGF5";
		buffer[5] = "ZXJMb2dpbkZpbmlzaFNjUnNwED4SEgoOQ21kUEVKUE9BQ0lJS0wQEBISCg5D";
		buffer[6] = "bWRHQlBFRUtLTkNPSxBOEhsKF0NtZFBsYXllckhlYXJ0QmVhdENzUmVxEAwS";
		buffer[7] = "JAogQ21kQ2xpZW50T2JqRG93bmxvYWREYXRhU2NOb3RpZnkQVhIVChFDbWRT";
		buffer[8] = "ZXRHZW5kZXJTY1JzcBAUEhgKFENtZEdldEJhc2ljSW5mb1NjUnNwECQSFgoS";
		buffer[9] = "Q21kR2V0QXV0aGtleVNjUnNwEEgSGwoXQ21kQ2xpZW50T2JqVXBsb2FkQ3NS";
		buffer[10] = "ZXEQUBIcChhDbWRNb250aENhcmRSZXdhcmROb3RpZnkQOxIYChRDbWRHZXRC";
		buffer[11] = "YXNpY0luZm9Dc1JlcRBHEh4KGkNtZEdldFZpZGVvVmVyc2lvbktleVNjUnNw";
		buffer[12] = "EEQSGgoWQ21kR2V0TGV2ZWxSZXdhcmRTY1JjcBBZEhIKDkNtZEhDQk1JUEZD";
		buffer[13] = "Q1BMECoSIgoeQ21kUmVzZXJ2ZVN0YW1pbmFFeGNoYW5nZUNzUmVxEA0SEgoO";
		buffer[14] = "Q21kS0ZHT0tQT0pLUEgQHBIZChVDbWRTZXRQbGF5ZXJJbmZvQ3NSZXEQXRIX";
		buffer[15] = "ChNDbWRQbGF5ZXJMb2dpbkNzUmVxEFsSGQoVQ21kU2V0UGxheWVySW5mb1Nj";
		buffer[16] = "UnNwEAISIwofQ21kR2V0TGV2ZWxSZXdhcmRUYWtlbkxpc3RDc1JlcRA6EhcK";
		buffer[17] = "E0NtZFBsYXllckxvZ2luU2NSc3AQChIXChNDbWRTZXROaWNrbmFtZUNzUmVx";
		buffer[18] = "ED0SEgoOQ21kTUhKQUtHRlBNQ0sQQxIiCh5DbWRGZWF0dXJlU3dpdGNoQ2xv";
		buffer[19] = "c2VkU2NOb3RpZnkQBhIXChNDbWRTZXROaWNrbmFtZVNjUnNwEAcSHgoaQ21k";
		buffer[20] = "R2V0VmlkZW9WZXJzaW9uS2V5Q3NSZXEQRhIfChtDbWRTZXRHYW1lcGxheUJp";
		buffer[21] = "cnRoZGF5Q3NSZXEQXBIiCh5DbWRMaWdodENvbmVSYXJpdHk0QXV0b0xvY2tS";
		buffer[22] = "ZXEQIxIYChRDbWRHZXRMZXZlbFJld2FyZFJlcRBkEh0KGUNtZFBsYXllclNx";
		buffer[23] = "dWVlemVkU2NOb3RpZnkQPxIfChtDbWRTZXRHYW1lcGxheUJpcnRoZGF5U2NS";
		buffer[24] = "c3AQGBIbChdDbWRQbGF5ZXJIZWFydEJlYXRTY1JzcBBNEiIKHkNtZFVwZGF0";
		buffer[25] = "ZUZlYXR1cmVTd2l0Y2hTY05vdGlmeRAeEh8KG0NtZFVwZGF0ZVBsYXllclNl";
		buffer[26] = "dHRpbmdTY1JzcBAPEhUKEUNtZFNldExhbmd1YWdlUmVxEBUSFgoSQ21kRW50";
		buffer[27] = "ZXJTdGFnZUNzUmVxEBoSJAogQ21kRm9yY2VTeW5jR2FtZVN0YXRlRmluaXNo";
		buffer[28] = "Q1NSZXEQMhIWChJDbWRHZXRBdXRoa2V5Q3NSZXEQJhIZChVDbWREYWlseVJl";
		buffer[29] = "ZnJlc2hOb3RpZnkQAxISCg5DbWRQSElCR0RGRUZFRRAgEhgKFENtZFBsYXll";
		buffer[30] = "ckxvZ291dENzUmVxEF4SGgoWQ21kU3RhbWluYUluZm9TY05vdGlmeRBTEhsK";
		buffer[31] = "F0xHREVKT05PR0RLX01ER0FJQ0ZCQ0tKEC8SEgoOQ21kTUhKT0pFRkVPS0sQ";
		buffer[32] = "KBISCg5DbWROQkNES0FPRk5NRBBiEhsKF0xHREVKT05PR0RLX09PT0lFSElD";
		buffer[33] = "TURNEF8SHAoYQ21kR2V0U2VjcmV0S2V5SW5mb0NzUmVxEFoSGwoXQ21kQ2xp";
		buffer[34] = "ZW50T2JqVXBsb2FkU2NSc3AQVRIiCh5DbWRSZXNlcnZlU3RhbWluYUV4Y2hh";
		buffer[35] = "bmdlU2NSc3AQHxISCg5DbWRIREVGUEJOTk1EShBREhIKDkNtZENJQUFOTUNQ";
		buffer[36] = "QkdGEB0SEgoOQ21kRERDQ0tEQ0VCT0oQExISCg5DbWRQREFOT0hCS0JCRhAn";
		buffer[37] = "EhsKF0NtZEV4Y2hhbmdlU3RhbWluYVNjUnNwEAQSIwofQ21kR2V0TGV2ZWxS";
		buffer[38] = "ZXdhcmRUYWtlbkxpc3RTY1JzcBAsEigKJENtZFVwZGF0ZVBsYXlXaXRoUHNu";
		buffer[39] = "T25seVNldHRpbmdDc1JlcRA3EhUKEUNtZFNldEdlbmRlckNzUmVxEE8SIAoc";
		buffer[40] = "Q21kU2V0UmVkUG9pbnRTdGF0dXNTY05vdGlmeRBSEhsKF0NtZFNlcnZlckFu";
		buffer[41] = "bm91bmNlTm90aWZ5EEESHQoZQ21kUGxheWVyTG9naW5GaW5pc2hDc1JlcRAp";
		buffer[42] = "EhwKGENtZFF1ZXJ5UHJvZHVjdEluZm9TY1JzcBAFEhkKFUNtZEFudGlBZGRp";
		buffer[43] = "Y3RTY05vdGlmeRAhEiEKHUNtZENsaWVudERvd25sb2FkRGF0YVNjTm90aWZ5";
		buffer[44] = "EAsSGgoWQ21kUGxheWVyR2V0VG9rZW5TY1JzcBASQhaqAhNNYXJjaDd0aEhv";
		buffer[45] = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdPlayerType) }, null, null));
	}
}
