using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AMDMKFGOAPOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AMDMKFGOAPOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBTURNS0ZHT0FQTy5wcm90bxoOSXRlbUxpc3QucHJvdG8iOgoLQU1ETUtG" + "R09BUE8SHAoJaXRlbV9saXN0GAwgASgLMgkuSXRlbUxpc3QSDQoFbGV2ZWwY" + "DSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AMDMKFGOAPO), AMDMKFGOAPO.Parser, new string[2] { "ItemList", "Level" }, null, null, null, null)
		}));
	}
}
