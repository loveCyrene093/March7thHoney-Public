using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DIHDDMPJCFAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DIHDDMPJCFAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFESUhERE1QSkNGQS5wcm90bypHCgtESUhERE1QSkNGQRIbChdESUhERE1Q" + "SkNGQV9QQ1BESEVMUEtFTRAAEhsKF0RJSERETVBKQ0ZBX09CSE9JR0xJQU1K" + "EAFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(DIHDDMPJCFA) }, null, null));
	}
}
