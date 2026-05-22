using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LNINNLAEANBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LNINNLAEANBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMTklOTkxBRUFOQi5wcm90bxoOSXRlbUxpc3QucHJvdG8iVQoLTE5JTk5M" + "QUVBTkISHAoJaXRlbV9saXN0GAQgASgLMgkuSXRlbUxpc3QSEwoLSUNERkRP" + "S0ZMQUsYBSABKA0SEwoLSkZOTlBFT0RJTk8YDSABKA1CFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LNINNLAEANB), LNINNLAEANB.Parser, new string[3] { "ItemList", "ICDFDOKFLAK", "JFNNPEODINO" }, null, null, null, null)
		}));
	}
}
