using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OEHDBMBNLOFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OEHDBMBNLOFReflection()
	{
		InlineArray12<string> buffer = default(InlineArray12<string>);
		buffer[0] = "ChFPRUhEQk1CTkxPRi5wcm90byrdAwoLT0VIREJNQk5MT0YSGwoXT0VIREJN";
		buffer[1] = "Qk5MT0ZfSExQT0NIRE5KTUEQABIbChdPRUhEQk1CTkxPRl9BQ0pQREhKR0tI";
		buffer[2] = "TxABEhsKF09FSERCTUJOTE9GX0NJSUlQTkJJUEJBEAISGwoXT0VIREJNQk5M";
		buffer[3] = "T0ZfQ0VGRUFQRk1QSUwQAxIbChdPRUhEQk1CTkxPRl9BQUFPSU5GSk5ERRAE";
		buffer[4] = "EhsKF09FSERCTUJOTE9GX01JUEJDQkNIREVOEAUSGwoXT0VIREJNQk5MT0Zf";
		buffer[5] = "SUtDTkhPSUhGS0oQBhIbChdPRUhEQk1CTkxPRl9GS0xMSkRHRUhNRhAHEhsK";
		buffer[6] = "F09FSERCTUJOTE9GX1BHTFBCT0dMRkNGEAgSGwoXT0VIREJNQk5MT0ZfTUpE";
		buffer[7] = "Rk9BQUNBT04QCRIbChdPRUhEQk1CTkxPRl9FRkNJT01BR1BBTxAKEhsKF09F";
		buffer[8] = "SERCTUJOTE9GX0NCR0hOQ0JCQ0pCEAsSGwoXT0VIREJNQk5MT0ZfTUFERk1O";
		buffer[9] = "S0hOQ0UQDBIbChdPRUhEQk1CTkxPRl9JS0VBSkNQTktOTRANEhsKF09FSERC";
		buffer[10] = "TUJOTE9GX01CRUxLUE9FSEJBEA4SGwoXT0VIREJNQk5MT0ZfRElHTUZDR0lQ";
		buffer[11] = "S0QQD0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(OEHDBMBNLOF) }, null, null));
	}
}
