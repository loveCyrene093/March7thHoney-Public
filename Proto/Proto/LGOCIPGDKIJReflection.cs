using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LGOCIPGDKIJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LGOCIPGDKIJReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChFMR09DSVBHREtJSi5wcm90byqvAgoLTEdPQ0lQR0RLSUoSGwoXTEdPQ0lQ";
		buffer[1] = "R0RLSUpfUENQREhFTFBLRU0QABIbChdMR09DSVBHREtJSl9JR0dGTU9CQktG";
		buffer[2] = "TRABEhsKF0xHT0NJUEdES0lKX0tQR0VJSEFFRUJDEAISGwoXTEdPQ0lQR0RL";
		buffer[3] = "SUpfTU1BT09OUEFQRFAQAxIbChdMR09DSVBHREtJSl9FR05ESkdLS0pITxAE";
		buffer[4] = "EhsKF0xHT0NJUEdES0lKX0hFTU1HS0lKTEVJEAUSGwoXTEdPQ0lQR0RLSUpf";
		buffer[5] = "QkZBR05FTlBKSkoQBhIbChdMR09DSVBHREtJSl9KQURDTEVBRkVKQxAHEhsK";
		buffer[6] = "F0xHT0NJUEdES0lKX0dBTEdGSU9NT0lPEAgSGwoXTEdPQ0lQR0RLSUpfT1BG";
		buffer[7] = "UE5ISUJFRUQQCUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(LGOCIPGDKIJ) }, null, null));
	}
}
