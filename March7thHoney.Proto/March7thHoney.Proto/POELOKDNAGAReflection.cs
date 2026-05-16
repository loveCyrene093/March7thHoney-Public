using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class POELOKDNAGAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static POELOKDNAGAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQT0VMT0tETkFHQS5wcm90byIvCgtQT0VMT0tETkFHQRIPCgdyZXRjb2Rl" + "GAEgASgNEg8KB2J1ZmZfaWQYByABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(POELOKDNAGA), POELOKDNAGA.Parser, new string[2] { "Retcode", "BuffId" }, null, null, null, null)
		}));
	}
}
