using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FCJCCECMHIHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FCJCCECMHIHReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFGQ0pDQ0VDTUhJSC5wcm90byKHAQoLRkNKQ0NFQ01ISUgSEwoLQ0ZJRE1N";
		buffer[1] = "RkZCT0UYAiABKAUSDwoHaXRlbV9pZBgDIAEoDRITCgtLUEdNQktLT0dKRxgF";
		buffer[2] = "IAEoDRITCgtBRUhLTkdCS1BCRRgGIAEoDRITCgtIS0lPTUNPQ0RORhgIIAEo";
		buffer[3] = "BRITCgtIQkNKUENNSlBIRRgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		buffer[4] = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FCJCCECMHIH), FCJCCECMHIH.Parser, new string[6] { "CFIDMMFFBOE", "ItemId", "KPGMBKKOGJG", "AEHKNGBKPBE", "HKIOMCOCDNF", "HBCJPCMJPHE" }, null, null, null, null)
		}));
	}
}
