using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JCGBNPKJKHBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JCGBNPKJKHBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKQ0dCTlBLSktIQi5wcm90byIxCgtKQ0dCTlBLSktIQhIRCgl1bmlxdWVf" + "aWQYBSABKA0SDwoHaXRlbV9pZBgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JCGBNPKJKHB), JCGBNPKJKHB.Parser, new string[2] { "UniqueId", "ItemId" }, null, null, null, null)
		}));
	}
}
