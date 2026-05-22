using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AIODMENCPKAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AIODMENCPKAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBSU9ETUVOQ1BLQS5wcm90byIgCgtBSU9ETUVOQ1BLQRIRCgl1bmlxdWVf" + "aWQYDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AIODMENCPKA), AIODMENCPKA.Parser, new string[1] { "UniqueId" }, null, null, null, null)
		}));
	}
}
