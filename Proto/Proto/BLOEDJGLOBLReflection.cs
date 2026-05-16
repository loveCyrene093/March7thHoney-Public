using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BLOEDJGLOBLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BLOEDJGLOBLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCTE9FREpHTE9CTC5wcm90bxoRREtCTkdESENOQ0gucHJvdG8iRgoLQkxP" + "RURKR0xPQkwSIQoLREdGR05NSkFMR0oYAyABKAsyDC5ES0JOR0RIQ05DSBIU" + "CgxwYXNzZW5nZXJfaWQYByABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[1] { DKBNGDHCNCHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BLOEDJGLOBL), BLOEDJGLOBL.Parser, new string[2] { "DGFGNMJALGJ", "PassengerId" }, null, null, null, null)
		}));
	}
}
