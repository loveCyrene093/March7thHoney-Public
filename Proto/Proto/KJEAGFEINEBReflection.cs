using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KJEAGFEINEBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KJEAGFEINEBReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChFLSkVBR0ZFSU5FQi5wcm90byqvAgoLS0pFQUdGRUlORUISGwoXS0pFQUdG";
		buffer[1] = "RUlORUJfQU1EQkVOQUdNQkgQABIbChdLSkVBR0ZFSU5FQl9LSEhKQUlPR1BL";
		buffer[2] = "QRABEhsKF0tKRUFHRkVJTkVCX0lORU5FT0pNUExFEAISGwoXS0pFQUdGRUlO";
		buffer[3] = "RUJfTklIQk1FTExBR08QAxIbChdLSkVBR0ZFSU5FQl9CTUxGQ0ZJQUxLQxAE";
		buffer[4] = "EhsKF0tKRUFHRkVJTkVCX0VNR09PUEZBRklHEAYSGwoXS0pFQUdGRUlORUJf";
		buffer[5] = "RU1CQkFORUFPS0YQBxIbChdLSkVBR0ZFSU5FQl9QS0dEQU1BREFQRBAIEhsK";
		buffer[6] = "F0tKRUFHRkVJTkVCX0JPRU5MSEpFTkhBEAkSGwoXS0pFQUdGRUlORUJfQUFP";
		buffer[7] = "RURJRk1LSEkQCkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(KJEAGFEINEB) }, null, null));
	}
}
