using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JBOELLFBFHBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JBOELLFBFHBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKQk9FTExGQkZIQi5wcm90bxoOSXRlbUxpc3QucHJvdG8iTAoLSkJPRUxM" + "RkJGSEISEwoLTEdIT09LTU5NQ0wYBCABKA0SGQoGcmV3YXJkGAkgASgLMgku" + "SXRlbUxpc3QSDQoFbGV2ZWwYDCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JBOELLFBFHB), JBOELLFBFHB.Parser, new string[3] { "LGHOOKMNMCL", "Reward", "Level" }, null, null, null, null)
		}));
	}
}
