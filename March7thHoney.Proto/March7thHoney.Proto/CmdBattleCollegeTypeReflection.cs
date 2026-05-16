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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChpDbWRCYXR0bGVDb2xsZWdlVHlwZS5wcm90byroAQoUQ21kQmF0dGxlQ29s";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "bGVnZVR5cGUSGwoXQktIR09PSktOR0lfUENQREhFTFBLRU0QABIhChxDbWRH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "ZXRCYXR0bGVDb2xsZWdlRGF0YUNzUmVxEJ8tEh8KGkNtZFN0YXJ0QmF0dGxl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "Q29sbGVnZVNjUnNwENIsEiEKHENtZEdldEJhdHRsZUNvbGxlZ2VEYXRhU2NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "c3AQziwSKwomQ21kU3luY0JhdHRsZUNvbGxlZ2VEYXRhQ2hhbmdlU2NOb3Rp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "ZnkQoi0SHwoaQ21kU3RhcnRCYXR0bGVDb2xsZWdlQ3NSZXEQoy1CFqoCE01h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdBattleCollegeType) }, null, null));
	}
}
