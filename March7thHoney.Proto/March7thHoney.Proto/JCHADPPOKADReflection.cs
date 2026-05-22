using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JCHADPPOKADReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JCHADPPOKADReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFKQ0hBRFBQT0tBRC5wcm90byq7AQoLSkNIQURQUE9LQUQSGwoXSkNIQURQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "UE9LQURfTU1BT09OUEFQRFAQABIbChdKQ0hBRFBQT0tBRF9ISUxISU5HT0dC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "QhABEhsKF0pDSEFEUFBPS0FEX1BMTU9JQkxNTkZBEAISGwoXSkNIQURQUE9L";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "QURfT0FNT0dOSUtCTE4QAxIbChdKQ0hBRFBQT0tBRF9KQ0pMQk9LSE9OSxAE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "EhsKF0pDSEFEUFBPS0FEX0pHUEtEREtNREJQEAVCFqoCE01hcmNoN3RoSG9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(JCHADPPOKAD) }, null, null));
	}
}
