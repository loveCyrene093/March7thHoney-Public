using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AEIMINCOFHFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AEIMINCOFHFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBRUlNSU5DT0ZIRi5wcm90bxoRSkZGT05JRFBOREEucHJvdG8iPQoLQUVJ" + "TUlOQ09GSEYSEwoLR0tGRUdJQkdFR0kYAiABKA0SGQoDcG9zGA4gASgOMgwu" + "SkZGT05JRFBOREFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { JFFONIDPNDAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AEIMINCOFHF), AEIMINCOFHF.Parser, new string[2] { "GKFEGIBGEGI", "Pos" }, null, null, null, null)
		}));
	}
}
