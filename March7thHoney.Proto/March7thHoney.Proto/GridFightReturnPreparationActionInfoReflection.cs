using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightReturnPreparationActionInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightReturnPreparationActionInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipHcmlkRmlnaHRSZXR1cm5QcmVwYXJhdGlvbkFjdGlvbkluZm8ucHJvdG8i" + "JgokR3JpZEZpZ2h0UmV0dXJuUHJlcGFyYXRpb25BY3Rpb25JbmZvQhaqAhNN" + "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightReturnPreparationActionInfo), GridFightReturnPreparationActionInfo.Parser, null, null, null, null, null)
		}));
	}
}
