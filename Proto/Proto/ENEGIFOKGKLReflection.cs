using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ENEGIFOKGKLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ENEGIFOKGKLReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFFTkVHSUZPS0dLTC5wcm90bxoRSUpLTkRLSkxNRU4ucHJvdG8iewoLRU5F";
		buffer[1] = "R0lGT0tHS0wSEwoLSEVJT05QRElGTk0YASABKA0SDgoGbWFwX2lkGAIgASgN";
		buffer[2] = "Eg8KB2FyZWFfaWQYAyABKA0SIQoLSEZESUZGQkNPR0oYBiADKAsyDC5JSktO";
		buffer[3] = "REtKTE1FThITCgtJR0VDR1BGTEdCQRgOIAEoDUIWqgITTWFyY2g3dGhIb25l";
		buffer[4] = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { IJKNDKJLMENReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ENEGIFOKGKL), ENEGIFOKGKL.Parser, new string[5] { "HEIONPDIFNM", "MapId", "AreaId", "HFDIFFBCOGJ", "IGECGPFLGBA" }, null, null, null, null)
		}));
	}
}
