using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AKCNBOEOAPAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AKCNBOEOAPAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBS0NOQk9FT0FQQS5wcm90byIvCgtBS0NOQk9FT0FQQRITCgtKRUNISkRE" + "TkhNTBgGIAEoBRILCgNrZXkYByABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AKCNBOEOAPA), AKCNBOEOAPA.Parser, new string[2] { "JECHJDDNHML", "Key" }, null, null, null, null)
		}));
	}
}
