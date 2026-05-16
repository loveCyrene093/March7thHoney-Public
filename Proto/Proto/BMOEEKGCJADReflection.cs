using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BMOEEKGCJADReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BMOEEKGCJADReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFCTU9FRUtHQ0pBRC5wcm90bxoRRU1GRkFJTUhFT08ucHJvdG8ihQEKC0JN";
		buffer[1] = "T0VFS0dDSkFEEg0KBWxldmVsGAQgASgNEhMKC0lBTkVQUENISU5NGAogASgI";
		buffer[2] = "Eh8KF2dyaWRfZmlnaHRfZXF1aXBtZW50X2lkGAsgASgNEg4KBnJhcml0eRgN";
		buffer[3] = "IAEoDRIhCgtEQ0xBS0NGSkNQShgOIAMoCzIMLkVNRkZBSU1IRU9PQhaqAhNN";
		buffer[4] = "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { EMFFAIMHEOOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BMOEEKGCJAD), BMOEEKGCJAD.Parser, new string[5] { "Level", "IANEPPCHINM", "GridFightEquipmentId", "Rarity", "DCLAKCFJCPJ" }, null, null, null, null)
		}));
	}
}
