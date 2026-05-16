using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdClientCustomOpTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdClientCustomOpTypeReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtDbWRDbGllbnRDdXN0b21PcFR5cGUucHJvdG8qSQoVQ21kQ2xpZW50Q3Vz" + "dG9tT3BUeXBlEhsKF0FMUFBIRUhOUExFX0JFRU5ESVBLS05KEAASEwoOQ21k" + "S09JUEhKRkVOSU4Q70xCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdClientCustomOpType) }, null, null));
	}
}
