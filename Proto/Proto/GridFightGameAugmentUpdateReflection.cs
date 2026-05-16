using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightGameAugmentUpdateReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightGameAugmentUpdateReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBHcmlkRmlnaHRHYW1lQXVnbWVudFVwZGF0ZS5wcm90bxoZR3JpZEdhbWVB" + "dWdtZW50SW5mby5wcm90byJPChpHcmlkRmlnaHRHYW1lQXVnbWVudFVwZGF0" + "ZRIxChN1cGRhdGVfYXVnbWVudF9pbmZvGAMgASgLMhQuR3JpZEdhbWVBdWdt" + "ZW50SW5mb0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { GridGameAugmentInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightGameAugmentUpdate), GridFightGameAugmentUpdate.Parser, new string[1] { "UpdateAugmentInfo" }, null, null, null, null)
		}));
	}
}
