using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LAOOIHPKMOOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LAOOIHPKMOOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMQU9PSUhQS01PTy5wcm90byJxCgtMQU9PSUhQS01PTxIOCgZpc193aW4Y" + "BSABKAgSEwoLTkhMR09DR01LQlAYBiABKAgSEwoLRExDS0JNTE1PSVAYCCAB" + "KAUSEwoLR0lIREdMTUpNSEMYCiABKA0SEwoLRk9PTE1JQURNTUgYDSABKA1C" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LAOOIHPKMOO), LAOOIHPKMOO.Parser, new string[5] { "IsWin", "NHLGOCGMKBP", "DLCKBMLMOIP", "GIHDGLMJMHC", "FOOLMIADMMH" }, null, null, null, null)
		}));
	}
}
