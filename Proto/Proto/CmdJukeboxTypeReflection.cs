using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdJukeboxTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdJukeboxTypeReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChRDbWRKdWtlYm94VHlwZS5wcm90byqdAgoOQ21kSnVrZWJveFR5cGUSGwoX";
		buffer[1] = "RUhQTkdNQ0JNQkZfUENQREhFTFBLRU0QABIiCh1DbWRVbmxvY2tCYWNrR3Jv";
		buffer[2] = "dW5kTXVzaWNDc1JlcRCqGBIbChZDbWRHZXRKdWtlYm94RGF0YVNjUnNwEKYY";
		buffer[3] = "EiAKG0NtZFBsYXlCYWNrR3JvdW5kTXVzaWNDc1JlcRD6GBITCg5DbWRJREVC";
		buffer[4] = "REdJQ0hBShClGBIbChZDbWRHZXRKdWtlYm94RGF0YUNzUmVxEPcYEhMKDkNt";
		buffer[5] = "ZENKQVBGT09PTktDEP4YEiIKHUNtZFVubG9ja0JhY2tHcm91bmRNdXNpY1Nj";
		buffer[6] = "UnNwEK4YEiAKG0NtZFBsYXlCYWNrR3JvdW5kTXVzaWNTY1JzcBD7GEIWqgIT";
		buffer[7] = "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdJukeboxType) }, null, null));
	}
}
