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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChtTY2VuZUdyb3VwUmVmcmVzaFR5cGUucHJvdG8qrgEKFVNjZW5lR3JvdXBS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "ZWZyZXNoVHlwZRIhCh1TQ0VORV9HUk9VUF9SRUZSRVNIX1RZUEVfTk9ORRAA";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "EiMKH1NDRU5FX0dST1VQX1JFRlJFU0hfVFlQRV9MT0FERUQQARIjCh9TQ0VO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "RV9HUk9VUF9SRUZSRVNIX1RZUEVfVU5MT0FEEAISKAokU0NFTkVfR1JPVVBf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "UkVGUkVTSF9UWVBFX0FGSUJGTUFGTkNDEANCFqoCE01hcmNoN3RoSG9uZXku";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(SceneGroupRefreshType) }, null, null));
	}
}
