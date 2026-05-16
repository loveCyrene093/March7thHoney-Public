using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneGroupRefreshTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneGroupRefreshTypeReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChtTY2VuZUdyb3VwUmVmcmVzaFR5cGUucHJvdG8qrgEKFVNjZW5lR3JvdXBS";
		buffer[1] = "ZWZyZXNoVHlwZRIhCh1TQ0VORV9HUk9VUF9SRUZSRVNIX1RZUEVfTk9ORRAA";
		buffer[2] = "EiMKH1NDRU5FX0dST1VQX1JFRlJFU0hfVFlQRV9MT0FERUQQARIjCh9TQ0VO";
		buffer[3] = "RV9HUk9VUF9SRUZSRVNIX1RZUEVfVU5MT0FEEAISKAokU0NFTkVfR1JPVVBf";
		buffer[4] = "UkVGUkVTSF9UWVBFX0FGSUJGTUFGTkNDEANCFqoCE01hcmNoN3RoSG9uZXku";
		buffer[5] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(SceneGroupRefreshType) }, null, null));
	}
}
