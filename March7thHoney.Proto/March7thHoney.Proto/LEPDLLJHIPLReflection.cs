using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LEPDLLJHIPLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LEPDLLJHIPLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMRVBETExKSElQTC5wcm90bypHCgtMRVBETExKSElQTBIbChdMRVBETExK" + "SElQTF9MREhMSUlKSk9EUBAAEhsKF0xFUERMTEpISVBMX0FQTkpDRkVGQktC" + "EAFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(LEPDLLJHIPL) }, null, null));
	}
}
