using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DirectDeliveryScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DirectDeliveryScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxEaXJlY3REZWxpdmVyeVNjTm90aWZ5LnByb3RvGg5JdGVtTGlzdC5wcm90" + "byJNChZEaXJlY3REZWxpdmVyeVNjTm90aWZ5Eh4KC0hBTEZHTEdMRExPGAEg" + "AygLMgkuSXRlbUxpc3QSEwoLT0VDQ1BLQU5ITU4YCSABKA1CFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DirectDeliveryScNotify), DirectDeliveryScNotify.Parser, new string[2] { "HALFGLGLDLO", "OECCPKANHMN" }, null, null, null, null)
		}));
	}
}
