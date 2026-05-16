using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdContentPackageTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdContentPackageTypeReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChtDbWRDb250ZW50UGFja2FnZVR5cGUucHJvdG8qzAEKFUNtZENvbnRlbnRQ";
		buffer[1] = "YWNrYWdlVHlwZRIbChdDR0RIS0dQSURMTV9QQ1BESEVMUEtFTRAAEiYKIUNt";
		buffer[2] = "ZENvbnRlbnRQYWNrYWdlU3luY0RhdGFTY05vdGlmeRDqOhIiCh1DbWRDb250";
		buffer[3] = "ZW50UGFja2FnZUdldERhdGFDc1JlcRDZOhIiCh1DbWRDb250ZW50UGFja2Fn";
		buffer[4] = "ZUdldERhdGFTY1JzcBDTOhImCiFDbWRDb250ZW50UGFja2FnZVRyYW5zZmVy";
		buffer[5] = "U2NOb3RpZnkQ8jpCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdContentPackageType) }, null, null));
	}
}
