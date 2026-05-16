using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightTraitActionResultReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightTraitActionResultReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBHcmlkRmlnaHRUcmFpdEFjdGlvblJlc3VsdC5wcm90byJAChpHcmlkRmln" + "aHRUcmFpdEFjdGlvblJlc3VsdBIRCgl1bmlxdWVfaWQYBSABKA0SDwoHcm9s" + "ZV9pZBgJIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightTraitActionResult), GridFightTraitActionResult.Parser, new string[2] { "UniqueId", "RoleId" }, null, null, null, null)
		}));
	}
}
