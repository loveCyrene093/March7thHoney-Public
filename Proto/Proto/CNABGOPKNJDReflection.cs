using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CNABGOPKNJDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CNABGOPKNJDReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFDTkFCR09QS05KRC5wcm90byKFAQoLQ05BQkdPUEtOSkQSDwoHaXRlbV9p";
		buffer[1] = "ZBgFIAEoDRITCgtBRUhLTkdCS1BCRRgKIAEoDRITCgtDRklETU1GRkJPRRgL";
		buffer[2] = "IAEoBRITCgtLUEdNQktLT0dKRxgMIAEoDRITCgtIS0lPTUNPQ0RORhgOIAEo";
		buffer[3] = "BRIRCgl1bmlxdWVfaWQYDyABKARCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		buffer[4] = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CNABGOPKNJD), CNABGOPKNJD.Parser, new string[6] { "ItemId", "AEHKNGBKPBE", "CFIDMMFFBOE", "KPGMBKKOGJG", "HKIOMCOCDNF", "UniqueId" }, null, null, null, null)
		}));
	}
}
