using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NADCNANJLBJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NADCNANJLBJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOQURDTkFOSkxCSi5wcm90byIyCgtOQURDTkFOSkxCShISCgp2aXNpdG9y" + "X2lkGAcgASgNEg8KB2lzX21lZXQYDSABKAhCFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NADCNANJLBJ), NADCNANJLBJ.Parser, new string[2] { "VisitorId", "IsMeet" }, null, null, null, null)
		}));
	}
}
