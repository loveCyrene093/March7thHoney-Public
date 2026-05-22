using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GeneralVirtualItemDataNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GeneralVirtualItemDataNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJHZW5lcmFsVmlydHVhbEl0ZW1EYXRhTm90aWZ5LnByb3RvGg5QaWxlSXRl" + "bS5wcm90byJTChxHZW5lcmFsVmlydHVhbEl0ZW1EYXRhTm90aWZ5Eh4KC0tD" + "SkNCQktLQ0dJGAMgAygLMgkuUGlsZUl0ZW0SEwoLTk9OTU9OUEhCUEUYDSAB" + "KAhCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { PileItemReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GeneralVirtualItemDataNotify), GeneralVirtualItemDataNotify.Parser, new string[2] { "KCJCBBKKCGI", "NONMONPHBPE" }, null, null, null, null)
		}));
	}
}
