using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LAEHDNHPGCCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LAEHDNHPGCCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMQUVIRE5IUEdDQy5wcm90byIvCgtMQUVIRE5IUEdDQxITCgtGQk5JT0hQ" + "RENJTBgDIAEoDRILCgNudW0YCyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LAEHDNHPGCC), LAEHDNHPGCC.Parser, new string[2] { "FBNIOHPDCIL", "Num" }, null, null, null, null)
		}));
	}
}
