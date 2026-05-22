using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesCustomKeyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesCustomKeyReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChhQbGFuZXRGZXNDdXN0b21LZXkucHJvdG8qpQEKElBsYW5ldEZlc0N1c3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "bUtleRIbChdPTk1LRFBDRUZKRV9QQ1BESEVMUEtFTRAAEhsKF09OTUtEUENF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "RkpFX0hLTkhOSk9KR0JMEAESGwoXT05NS0RQQ0VGSkVfQUVLUEdMSkxPSE0Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "AhIbChdPTk1LRFBDRUZKRV9DQUxOQ0dJRkZDQhADEhsKF09OTUtEUENFRkpF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "X01JR01MT0tFUEdMEARCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(PlanetFesCustomKey) }, null, null));
	}
}
