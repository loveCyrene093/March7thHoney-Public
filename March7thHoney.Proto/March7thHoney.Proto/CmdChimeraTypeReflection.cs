using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdChimeraTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdChimeraTypeReflection()
	{
		InlineArray14<string> buffer = default(InlineArray14<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 0) = "ChRDbWRDaGltZXJhVHlwZS5wcm90byqjBAoOQ21kQ2hpbWVyYVR5cGUSGwoX";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 1) = "RUNHQ1BLTEhERUNfUENQREhFTFBLRU0QABIgChtDbWRDaGltZXJhU3RhcnRF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 2) = "bmRsZXNzQ3NSZXEQ7j8SFAoPQ21kR2V0RGF0YVNjUnNwEPQ/EiYKIUNtZENo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 3) = "aW1lcmFGaW5pc2hFbmRsZXNzUm91bmRTY1JzcBDzPxIfChpDbWRDaGltZXJh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 4) = "UXVpdEVuZGxlc3NTY1JzcBDyPxIfChpDbWRDaGltZXJhRmluaXNoUm91bmRD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 5) = "c1JlcRDvPxIaChVDbWRDaGltZXJhRmluaXNoUm91bmQQ6D8SEwoOQ21kSU5J";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 6) = "RUxEQ0FHREcQ7T8SIAobQ21kQ2hpbWVyYURvRmluYWxSb3VuZFNjUnNwEOM/";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 7) = "EiAKG0NtZENoaW1lcmFTdGFydEVuZGxlc3NTY1JzcBDxPxIgChtDbWRDaGlt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 8) = "ZXJhRG9GaW5hbFJvdW5kQ3NSZXEQ5D8SIgodQ21kQ2hpbWVyYVJvdW5kV29y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 9) = "a1N0YXJ0Q3NSZXEQ6T8SGwoWQ21kQ2hpbWVyYUdldERhdGFDc1JlcRDhPxIc";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 10) = "ChdFQ0dDUEtMSERFQ19BSUNPRU5FUEFDTRDiPxITCg5DbWRPSUpKRE1HT0RK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 11) = "UBDqPxImCiFDbWRDaGltZXJhRmluaXNoRW5kbGVzc1JvdW5kQ3NSZXEQ5z8S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 12) = "HwoaQ21kQ2hpbWVyYVF1aXRFbmRsZXNzQ3NSZXEQ6z9CFqoCE01hcmNoN3Ro";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 13) = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray14<string>, string>(in buffer, 14))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdChimeraType) }, null, null));
	}
}
