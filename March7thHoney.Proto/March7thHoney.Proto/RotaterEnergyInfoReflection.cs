using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RotaterEnergyInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RotaterEnergyInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdSb3RhdGVyRW5lcmd5SW5mby5wcm90byI1ChFSb3RhdGVyRW5lcmd5SW5m" + "bxIPCgdjdXJfbnVtGAEgASgNEg8KB21heF9udW0YAyABKA1CFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RotaterEnergyInfo), RotaterEnergyInfo.Parser, new string[2] { "CurNum", "MaxNum" }, null, null, null, null)
		}));
	}
}
