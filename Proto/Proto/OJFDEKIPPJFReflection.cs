using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OJFDEKIPPJFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OJFDEKIPPJFReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFPSkZERUtJUFBKRi5wcm90bxoRRUlQUEdGQ0ZKRU8ucHJvdG8aEUlMTEJO";
		buffer[1] = "S0ZCTkJQLnByb3RvIn0KC09KRkRFS0lQUEpGEiEKC0ZLS0xISUhFRUZNGAEg";
		buffer[2] = "AygLMgwuSUxMQk5LRkJOQlASIQoLQUlGS0tDREJISkcYBSADKAsyDC5FSVBQ";
		buffer[3] = "R0ZDRkpFTxITCgtIS0JGQUlOQ0tISRgKIAMoDRITCgtFRUVKTENMR0FHQxgO";
		buffer[4] = "IAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			EIPPGFCFJEOReflection.Descriptor,
			ILLBNKFBNBPReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OJFDEKIPPJF), OJFDEKIPPJF.Parser, new string[4] { "FKKLHIHEEFM", "AIFKKCDBHJG", "HKBFAINCKHI", "EEEJLCLGAGC" }, null, null, null, null)
		}));
	}
}
