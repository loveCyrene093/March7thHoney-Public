using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OBNJKBMEAOLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OBNJKBMEAOLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPQk5KS0JNRUFPTC5wcm90byIpCgtPQk5KS0JNRUFPTBINCgV2YWx1ZRgD" + "IAEoERILCgNrZXkYDCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OBNJKBMEAOL), OBNJKBMEAOL.Parser, new string[2] { "Value", "Key" }, null, null, null, null)
		}));
	}
}
