using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightGameAugmentAddReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightGameAugmentAddReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1HcmlkRmlnaHRHYW1lQXVnbWVudEFkZC5wcm90bxoZR3JpZEdhbWVBdWdt" + "ZW50SW5mby5wcm90byJMChdHcmlkRmlnaHRHYW1lQXVnbWVudEFkZBIxChN1" + "cGRhdGVfYXVnbWVudF9pbmZvGAMgASgLMhQuR3JpZEdhbWVBdWdtZW50SW5m" + "b0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { GridGameAugmentInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightGameAugmentAdd), GridFightGameAugmentAdd.Parser, new string[1] { "UpdateAugmentInfo" }, null, null, null, null)
		}));
	}
}
