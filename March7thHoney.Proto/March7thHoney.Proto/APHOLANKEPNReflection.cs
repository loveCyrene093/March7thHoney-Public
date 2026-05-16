using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class APHOLANKEPNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static APHOLANKEPNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBUEhPTEFOS0VQTi5wcm90byIvCgtBUEhPTEFOS0VQThITCgtGQk5JT0hQ" + "RENJTBgGIAEoDRILCgNudW0YDCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(APHOLANKEPN), APHOLANKEPN.Parser, new string[2] { "FBNIOHPDCIL", "Num" }, null, null, null, null)
		}));
	}
}
