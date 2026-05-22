using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HNEJHAJJIOBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HNEJHAJJIOBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFITkVKSEFKSklPQi5wcm90byImCgtITkVKSEFKSklPQhIXCg9lbGl0ZV9i" + "cmFuY2hfaWQYDiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HNEJHAJJIOB), HNEJHAJJIOB.Parser, new string[1] { "EliteBranchId" }, null, null, null, null)
		}));
	}
}
