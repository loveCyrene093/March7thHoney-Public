using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KickTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KickTypeReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Cg5LaWNrVHlwZS5wcm90byqLAQoIS2lja1R5cGUSEQoNS0lDS19TUVVFRVpF";
		buffer[1] = "RBAAEg4KCktJQ0tfQkxBQ0sQARITCg9LSUNLX0NIQU5HRV9QV0QQAhIcChhL";
		buffer[2] = "SUNLX0xPR0lOX1dISVRFX1RJTUVPVVQQAxIZChVLSUNLX0FDRV9BTlRJX0NI";
		buffer[3] = "RUFURVIQBBIOCgpLSUNLX0JZX0dNEAVCFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		buffer[4] = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(KickType) }, null, null));
	}
}
