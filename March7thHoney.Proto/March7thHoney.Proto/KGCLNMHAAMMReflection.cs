using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KGCLNMHAAMMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KGCLNMHAAMMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLR0NMTk1IQUFNTS5wcm90byIjCgtLR0NMTk1IQUFNTRIJCgF5GAcgASgC" + "EgkKAXgYCCABKAJCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KGCLNMHAAMM), KGCLNMHAAMM.Parser, new string[2] { "Y", "X" }, null, null, null, null)
		}));
	}
}
