using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HABJHHLPLFGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HABJHHLPLFGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIQUJKSEhMUExGRy5wcm90bxoOSXRlbUxpc3QucHJvdG8iKwoLSEFCSkhI" + "TFBMRkcSHAoJaXRlbV9saXN0GAYgASgLMgkuSXRlbUxpc3RCFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HABJHHLPLFG), HABJHHLPLFG.Parser, new string[1] { "ItemList" }, null, null, null, null)
		}));
	}
}
