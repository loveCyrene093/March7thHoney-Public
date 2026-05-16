using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GLEFCCGNKDEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GLEFCCGNKDEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHTEVGQ0NHTktERS5wcm90byImCgtHTEVGQ0NHTktERRILCgNjbnQYBSAB" + "KA0SCgoCaWQYCiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GLEFCCGNKDE), GLEFCCGNKDE.Parser, new string[2] { "Cnt", "Id" }, null, null, null, null)
		}));
	}
}
