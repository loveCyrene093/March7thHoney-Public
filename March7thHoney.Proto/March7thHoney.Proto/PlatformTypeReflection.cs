using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlatformTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlatformTypeReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 0) = "ChJQbGF0Zm9ybVR5cGUucHJvdG8q3gIKDFBsYXRmb3JtVHlwZRIKCgZFRElU";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 1) = "T1IQABIHCgNJT1MQARILCgdBTkRST0lEEAISBgoCUEMQAxIHCgNXRUIQBBIH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 2) = "CgNXQVAQBRIHCgNQUzQQBhIMCghOSU5URU5ETxAHEhEKDUNMT1VEX0FORFJP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 3) = "SUQQCBIMCghDTE9VRF9QQxAJEg0KCUNMT1VEX0lPUxAKEgcKA1BTNRALEgcK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 4) = "A01BQxAMEg0KCUNMT1VEX01BQxANEhUKEUNMT1VEX1dFQl9BTkRST0lEEBQS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 5) = "EQoNQ0xPVURfV0VCX0lPUxAVEhAKDENMT1VEX1dFQl9QQxAWEhEKDUNMT1VE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 6) = "X1dFQl9NQUMQFxITCg9DTE9VRF9XRUJfVE9VQ0gQGBIWChJDTE9VRF9XRUJf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 7) = "S0VZQk9BUkQQGRIUChBDTE9VRF9ET1VZSU5fSU9TEBsSGAoUQ0xPVURfRE9V";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 8) = "WUlOX0FORFJPSUQQHEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray9<string>, string>(in buffer, 9))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(PlatformType) }, null, null));
	}
}
