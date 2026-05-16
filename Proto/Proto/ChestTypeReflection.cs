using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChestTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChestTypeReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Cg9DaGVzdFR5cGUucHJvdG8qjAEKCUNoZXN0VHlwZRIcChhNQVBfSU5GT19D";
		buffer[1] = "SEVTVF9UWVBFX05PTkUQABIeChpNQVBfSU5GT19DSEVTVF9UWVBFX05PUk1B";
		buffer[2] = "TBBlEiEKHU1BUF9JTkZPX0NIRVNUX1RZUEVfQ0hBTExFTkdFEGYSHgoaTUFQ";
		buffer[3] = "X0lORk9fQ0hFU1RfVFlQRV9QVVpaTEUQaEIWqgITTWFyY2g3dGhIb25leS5Q";
		buffer[4] = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(ChestType) }, null, null));
	}
}
