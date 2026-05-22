using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DKBJKODADGMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DKBJKODADGMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFES0JKS09EQURHTS5wcm90byJZCgtES0JKS09EQURHTRIRCgl1bmlxdWVf" + "aWQYBiABKA0SEQoJY3VyX2luZGV4GAogASgNEhMKC0xHTURJR0xFS0VOGAwg" + "AygNEg8KB2NhcmRfaWQYDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DKBJKODADGM), DKBJKODADGM.Parser, new string[4] { "UniqueId", "CurIndex", "LGMDIGLEKEN", "CardId" }, null, null, null, null)
		}));
	}
}
