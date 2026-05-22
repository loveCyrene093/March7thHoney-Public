using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EICJJJFFLBIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EICJJJFFLBIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFSUNKSkpGRkxCSS5wcm90byIvCgtFSUNKSkpGRkxCSRIPCgdyZXRjb2Rl" + "GAYgASgNEg8KB2l0ZW1faWQYDSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EICJJJFFLBI), EICJJJFFLBI.Parser, new string[2] { "Retcode", "ItemId" }, null, null, null, null)
		}));
	}
}
