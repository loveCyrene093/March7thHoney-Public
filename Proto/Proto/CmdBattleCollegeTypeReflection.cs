using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdBattleCollegeTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdBattleCollegeTypeReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChpDbWRCYXR0bGVDb2xsZWdlVHlwZS5wcm90byroAQoUQ21kQmF0dGxlQ29s";
		buffer[1] = "bGVnZVR5cGUSGwoXQktIR09PSktOR0lfUENQREhFTFBLRU0QABIhChxDbWRH";
		buffer[2] = "ZXRCYXR0bGVDb2xsZWdlRGF0YUNzUmVxEJ8tEh8KGkNtZFN0YXJ0QmF0dGxl";
		buffer[3] = "Q29sbGVnZVNjUnNwENIsEiEKHENtZEdldEJhdHRsZUNvbGxlZ2VEYXRhU2NS";
		buffer[4] = "c3AQziwSKwomQ21kU3luY0JhdHRsZUNvbGxlZ2VEYXRhQ2hhbmdlU2NOb3Rp";
		buffer[5] = "ZnkQoi0SHwoaQ21kU3RhcnRCYXR0bGVDb2xsZWdlQ3NSZXEQoy1CFqoCE01h";
		buffer[6] = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdBattleCollegeType) }, null, null));
	}
}
