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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "ChRDbWRKdWtlYm94VHlwZS5wcm90byqdAgoOQ21kSnVrZWJveFR5cGUSGwoX";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "RUhQTkdNQ0JNQkZfUENQREhFTFBLRU0QABIiCh1DbWRVbmxvY2tCYWNrR3Jv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "dW5kTXVzaWNDc1JlcRCqGBIbChZDbWRHZXRKdWtlYm94RGF0YVNjUnNwEKYY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "EiAKG0NtZFBsYXlCYWNrR3JvdW5kTXVzaWNDc1JlcRD6GBITCg5DbWRJREVC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "REdJQ0hBShClGBIbChZDbWRHZXRKdWtlYm94RGF0YUNzUmVxEPcYEhMKDkNt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "ZENKQVBGT09PTktDEP4YEiIKHUNtZFVubG9ja0JhY2tHcm91bmRNdXNpY1Nj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "UnNwEK4YEiAKG0NtZFBsYXlCYWNrR3JvdW5kTXVzaWNTY1JzcBD7GEIWqgIT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdJukeboxType) }, null, null));
	}
}
