using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightHandBookAugmentInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightHandBookAugmentInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJHcmlkRmlnaHRIYW5kQm9va0F1Z21lbnRJbmZvLnByb3RvIkgKHEdyaWRG" + "aWdodEhhbmRCb29rQXVnbWVudEluZm8SEwoLS0RGQkNNQU5GTUIYCyADKA0S" + "EwoLSkxDREVES1BFQUIYDSADKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightHandBookAugmentInfo), GridFightHandBookAugmentInfo.Parser, new string[2] { "KDFBCMANFMB", "JLCDEDKPEAB" }, null, null, null, null)
		}));
	}
}
