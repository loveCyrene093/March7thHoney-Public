using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MBINEIHNOGCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MBINEIHNOGCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNQklORUlITk9HQy5wcm90byIgCgtNQklORUlITk9HQxIRCgl1bmlxdWVf" + "aWQYCiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MBINEIHNOGC), MBINEIHNOGC.Parser, new string[1] { "UniqueId" }, null, null, null, null)
		}));
	}
}
