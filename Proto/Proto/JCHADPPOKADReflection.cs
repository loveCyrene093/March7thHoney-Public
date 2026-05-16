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
		buffer[0] = "ChFKQ0hBRFBQT0tBRC5wcm90byq7AQoLSkNIQURQUE9LQUQSGwoXSkNIQURQ";
		buffer[1] = "UE9LQURfTU1BT09OUEFQRFAQABIbChdKQ0hBRFBQT0tBRF9ISUxISU5HT0dC";
		buffer[2] = "QhABEhsKF0pDSEFEUFBPS0FEX1BMTU9JQkxNTkZBEAISGwoXSkNIQURQUE9L";
		buffer[3] = "QURfT0FNT0dOSUtCTE4QAxIbChdKQ0hBRFBQT0tBRF9KQ0pMQk9LSE9OSxAE";
		buffer[4] = "EhsKF0pDSEFEUFBPS0FEX0pHUEtEREtNREJQEAVCFqoCE01hcmNoN3RoSG9u";
		buffer[5] = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(JCHADPPOKAD) }, null, null));
	}
}
