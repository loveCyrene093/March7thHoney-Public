using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OHLCKLEKPINReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OHLCKLEKPINReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFPSExDS0xFS1BJTi5wcm90byKKAQoLT0hMQ0tMRUtQSU4SEwoLQUxJR0VG";
		buffer[1] = "S01NR0gYASABKAMSEwoLTUpJRE1CSk5HRUkYAiABKA0SEwoLQkdEQkNBS0pN";
		buffer[2] = "TUEYBSABKA0SEgoKaGFzX3Bhc3NlZBgHIAEoCBITCgtDRklPTktLSVBKTBgK";
		buffer[3] = "IAEoCBITCgtBRkRCSEdDQUpEQhgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q";
		buffer[4] = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OHLCKLEKPIN), OHLCKLEKPIN.Parser, new string[6] { "ALIGEFKMMGH", "MJIDMBJNGEI", "BGDBCAKJMMA", "HasPassed", "CFIONKKIPJL", "AFDBHGCAJDB" }, null, null, null, null)
		}));
	}
}
