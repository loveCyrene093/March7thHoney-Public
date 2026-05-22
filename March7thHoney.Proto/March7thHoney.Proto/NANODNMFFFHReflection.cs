using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NANODNMFFFHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NANODNMFFFHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOQU5PRE5NRkZGSC5wcm90byI1CgtOQU5PRE5NRkZGSBIRCglhdmF0YXJf" + "aWQYBCABKA0SEwoLR0ROSUhBTE9LSEMYByABKAhCFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NANODNMFFFH), NANODNMFFFH.Parser, new string[2] { "AvatarId", "GDNIHALOKHC" }, null, null, null, null)
		}));
	}
}
