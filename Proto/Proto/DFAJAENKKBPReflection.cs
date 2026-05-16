using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DFAJAENKKBPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DFAJAENKKBPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFERkFKQUVOS0tCUC5wcm90byIxCgtERkFKQUVOS0tCUBIRCgl1bmlxdWVf" + "aWQYBCABKA0SDwoHcm9sZV9pZBgHIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DFAJAENKKBP), DFAJAENKKBP.Parser, new string[2] { "UniqueId", "RoleId" }, null, null, null, null)
		}));
	}
}
