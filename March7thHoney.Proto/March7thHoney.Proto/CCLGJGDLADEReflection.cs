using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CCLGJGDLADEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CCLGJGDLADEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDQ0xHSkdETEFERS5wcm90byIxCgtDQ0xHSkdETEFERRITCgtMQkdOSFBI" + "SEpORRgBIAEoBRINCgV2YWx1ZRgCIAEoCUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CCLGJGDLADE), CCLGJGDLADE.Parser, new string[2] { "LBGNHPHHJNE", "Value" }, null, null, null, null)
		}));
	}
}
