using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdFightMarbleTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdFightMarbleTypeReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhDbWRGaWdodE1hcmJsZVR5cGUucHJvdG8qMQoSQ21kRmlnaHRNYXJibGVU" + "eXBlEhsKF0RHTUlITUZOT01CX1BDUERIRUxQS0VNEABCFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdFightMarbleType) }, null, null));
	}
}
