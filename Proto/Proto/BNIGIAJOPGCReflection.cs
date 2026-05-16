using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BNIGIAJOPGCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BNIGIAJOPGCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCTklHSUFKT1BHQy5wcm90bxoVTW92aWVSYWNpbmdUeXBlLnByb3RvImYK" + "C0JOSUdJQUpPUEdDEhMKC0NFRUdHQ1BQQUZKGAEgASgNEhMKC0lMSERCSE1B" + "QU1PGAYgASgNEg0KBWxldmVsGA0gASgNEh4KBHR5cGUYDiABKA4yEC5Nb3Zp" + "ZVJhY2luZ1R5cGVCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { MovieRacingTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BNIGIAJOPGC), BNIGIAJOPGC.Parser, new string[4] { "CEEGGCPPAFJ", "ILHDBHMAAMO", "Level", "Type" }, null, null, null, null)
		}));
	}
}
