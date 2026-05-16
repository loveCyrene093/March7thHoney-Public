using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightEliteBranchActionResultReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightEliteBranchActionResultReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZHcmlkRmlnaHRFbGl0ZUJyYW5jaEFjdGlvblJlc3VsdC5wcm90byI7CiBH" + "cmlkRmlnaHRFbGl0ZUJyYW5jaEFjdGlvblJlc3VsdBIXCg9lbGl0ZV9icmFu" + "Y2hfaWQYDiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightEliteBranchActionResult), GridFightEliteBranchActionResult.Parser, new string[1] { "EliteBranchId" }, null, null, null, null)
		}));
	}
}
