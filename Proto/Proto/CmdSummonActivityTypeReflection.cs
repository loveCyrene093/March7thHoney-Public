using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdSummonActivityTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdSummonActivityTypeReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChtDbWRTdW1tb25BY3Rpdml0eVR5cGUucHJvdG8q8wEKFUNtZFN1bW1vbkFj";
		buffer[1] = "dGl2aXR5VHlwZRIbChdKTkpJRkJDTU5FR19QQ1BESEVMUEtFTRAAEiIKHUNt";
		buffer[2] = "ZEdldFN1bW1vbkFjdGl2aXR5RGF0YUNzUmVxEJE7EicKIkNtZFN1bW1vbkFj";
		buffer[3] = "dGl2aXR5QmF0dGxlRW5kU2NOb3RpZnkQjTsSJQogQ21kRW50ZXJTdW1tb25B";
		buffer[4] = "Y3Rpdml0eVN0YWdlU2NSc3AQjzsSJQogQ21kRW50ZXJTdW1tb25BY3Rpdml0";
		buffer[5] = "eVN0YWdlQ3NSZXEQiTsSIgodQ21kR2V0U3VtbW9uQWN0aXZpdHlEYXRhU2NS";
		buffer[6] = "c3AQkjtCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdSummonActivityType) }, null, null));
	}
}
